using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((1.0 - 3.8) >= (double)offset) || ((double)offset > (3.0 + 2.76)))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ score) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long target)
        {
            if ((seed + seed) == (target + seed))
            {
                return 7;
            }
            else
            {
                if ((target & 31) < target)
                {
                    return 4;
                }
                else
                {
                    if (!((seed << 1) > (seed >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed & 127) == (seed << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
