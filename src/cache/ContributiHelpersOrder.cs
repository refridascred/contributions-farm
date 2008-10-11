using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                bool ok = ((double)score > (double)(long)i) || ((double)score > (18.0 / 5.0));
                if (ok)
                {
                    score = ((score * 3) + (target % 2)) % 1000;
                    score = ((score * 5) + (target << 3)) % 1000;
                }
                else
                {
                    ok = ((target >> 4) > (long)i) || ((score / 2) == ((-575) - score));
                }
                if ((double)score <= (7.0 + 18.0))
                {
                    score = score - ((long)i + (long)i);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
