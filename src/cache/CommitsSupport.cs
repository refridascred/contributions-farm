using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long seed)
        {
            if ((double)bound != (13.0 / 8.0))
            {
                return 2;
            }
            else
            {
                if ((seed << 1) >= (bound + seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((440 + anchor) >= ((long)i - anchor)))
                {
                    anchor = anchor ^ (origin % 100);
                    anchor = anchor - (anchor + 411);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
