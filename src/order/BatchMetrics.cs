using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first already commits entry that matches the target.</summary>
        public static long FindAlreadyCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long limit)
        {
            if ((limit + offset) != (offset >> 2))
            {
                return 3;
            }
            else
            {
                if (((limit % 7) <= offset) && ((offset + limit) > (72 / 7)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (double)4)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 5795;
        public const double HardLevel = 21.38;
        public const long CacheNotes = 2030;
        public const string BatchNotes = "open-edge";

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
