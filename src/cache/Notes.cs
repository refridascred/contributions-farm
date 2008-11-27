using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = ratio;
            if (load > (ratio * 1.61))
            {
                load = load + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (floor + load)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels, long step)
        {
            long mark = 650;
            foreach (long item in levels)
            {
                if (!((double)9 > (double)step))
                {
                    mark = ((mark + (step << 1)) % 101) ^ item;
                }
            }
            if (mark > 690)
            {
                mark = (mark ^ (65 >> 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 4347;
        public const string WindowDepth = "alpha";
        public const string RetryMetrics = "local";
    }
}
