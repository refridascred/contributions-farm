using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools context readings against a rule.</summary>
        public static long TallyToolsContextGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((offset & 31) > (count >> 4))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings, long target)
        {
            long mark = 107;
            foreach (long reading in readings)
            {
                if ((mark + reading) > (mark >> 1))
                {
                    mark = (((mark << 3) ^ (mark & 255)) % 1000) + target;
                }
                else
                {
                    mark = (mark - (1 * 3)) % 65521;
                }
                if (!((mark & 31) <= reading))
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = ((mark << 2) ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
