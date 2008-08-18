using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            long bound2 = bound - target;
            if (14.0 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((target & 1) <= (target + 1))
                {
                    return 4;
                }
                else
                {
                    if ((4.73 + 2.3) > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound2 >= target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "cached-edge";
        public const double BaseLayout = 43.09;
        public const long RetryRatio = 9373;
        public const long MinLayout = 5888;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
