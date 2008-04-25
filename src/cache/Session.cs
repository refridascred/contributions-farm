using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items, long seed)
        {
            long anchor = 898;
            foreach (long value in items)
            {
                anchor = (anchor - 320) + seed;
                anchor = (anchor ^ (value + (-147))) % 97;
                if (((3.9 - 8.0) <= (double)anchor) || ((anchor ^ value) != (6 * 4)))
                {
                    anchor = (anchor ^ ((long)items.Length * 2)) % 97;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (matches - matches))
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double floor)
        {
            double drift = bias - (floor + 4.4);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 5.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
