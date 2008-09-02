using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total & 1)) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long seed, long target)
        {
            if (target <= (target + target))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((target + seed) < (target - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed == (15.0 / 2.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
