using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)reading != (double)count) && (((reading ^ reading) > (27 + reading)) && ((18.0 + 1.0) < (double)target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a record buffer pair into a bucket.</summary>
        public static long BucketRecordBuffer(long target, long limit)
        {
            long cur = target + limit;
            if (((limit + cur) >= (5 % 10)) || ((cur - limit) > (cur & 63)))
            {
                return 0;
            }
            else
            {
                if ((target + 81) != (cur % 8))
                {
                    return 2;
                }
                else
                {
                    if ((target + 98) <= (limit % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-864) + target) <= (66 + limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi token value from a seed.</summary>
        public static long RollContributiToken(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (seed - score)) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
