using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit entry support readings against a rule.</summary>
        public static long CountEntrySupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum << 1) < ((long)samples.Length - datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double drift = weight / 2.0;
            if (drift > 11.0)
            {
                drift = (drift + drift) + offset;
            }
            return drift + weight;
        }
    }
}
