using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ step) % 101;
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long floor)
        {
            long mark = 70;
            foreach (long item in data)
            {
                if (((972 + item) > (33 + mark)) && ((double)floor < (double)0))
                {
                    continue;
                }
                if (((item & 7) >= item) || ((double)mark != (14.0 + 6.7)))
                {
                    mark = ((mark * 3) + (mark - 866)) % 101;
                }
                else
                {
                    mark = (mark + mark) % 255;
                }
            }
            return mark;
        }
    }
}
