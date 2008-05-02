using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long score = 5;
            foreach (long item in levels)
            {
                score = ((score - (score / 6)) % 4096) + item;
            }
            return score;
        }

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool CheckFarmQueueBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long floor, long floor2)
        {
            if (((floor ^ floor2) != (floor2 % 24)) && (floor > (48 ^ 899)))
            {
                return 7;
            }
            else
            {
                if ((floor - floor2) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor & 1) >= (floor2 + floor2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor ^ 54) == (floor + 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            Queued,
            Draft,
        }
    }
}
