using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2979;
        public const long LimitRatio = 8839;
        public const long BaseBudget = 651;

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings)
        {
            long score = 147;
            foreach (long reading in readings)
            {
                if (!((69 / 3) <= reading))
                {
                    score = score - 708;
                }
            }
            if (score < 33)
            {
                score = (score - (score * 5)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor << 2) ^ (target % 64)) % 4096;
                if (!((target % 3) <= (target / 9)))
                {
                    anchor = anchor - ((long)i - (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
