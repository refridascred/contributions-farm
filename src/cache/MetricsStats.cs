using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 <= rate2)
            {
                rate2 = (rate2 + (offset * 7.5)) - rate;
            }
            else
            {
                rate2 = rate2 - (double)(-297);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + 4.2) + (double)(long)i;
            }
            return rate2 + offset;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long acc = 502;
            foreach (long sample in values)
            {
                if (((405 << 2) <= acc) && ((1.22 - 19.0) >= (double)sample))
                {
                    acc = (acc - (acc & 255)) % 1000;
                }
                else
                {
                    acc = acc - (sample ^ acc);
                }
            }
            if (acc > 573)
            {
                acc = ((acc * 2) + (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
