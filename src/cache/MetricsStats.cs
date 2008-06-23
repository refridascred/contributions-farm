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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long origin)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (acc - ((long)i % 7)) - origin;
                }
                acc = (acc - (cell % 16)) % 255;
                if ((cell + (long)samples.Length) < (acc % 10))
                {
                    acc = acc + (cell - cell);
                }
            }
            if (acc < 17)
            {
                acc = (acc - 69) % 255;
            }
            return acc;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next session context value from a seed.</summary>
        public static long IterateSessionContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i * 2)) % 101;
                if ((double)anchor != (0.34 * 9.0))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + (step / 4)) % 1000;
                }
                anchor = (anchor - (step % 60)) % 97;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
