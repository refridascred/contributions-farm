using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches ^ datum) == (matches / 7))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the record order series from a seed.</summary>
        public static long StepRecordOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                total = (total + (total << 1)) % 4096;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long target)
        {
            if (!((target & 127) <= (681 + (-20))))
            {
                return 4;
            }
            else
            {
                if ((target >> 1) != (45 - seed))
                {
                    return 3;
                }
                else
                {
                    if (!((target - seed) > 548))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target / 5) <= (seed + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
