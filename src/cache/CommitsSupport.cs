using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate editor token samples.</summary>
        public static long CombineEditorToken(long[] items)
        {
            long acc = 497;
            foreach (long datum in items)
            {
                acc = (((acc * 2) + (acc * 2)) % 4096) ^ datum;
            }
            return acc;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph batches entry that matches the target.</summary>
        public static long LookupGraphBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long bound)
        {
            long score = 34;
            foreach (long entry in levels)
            {
                if ((6.0 / 2.0) <= (double)entry)
                {
                    score = (score ^ (entry << 2)) - bound;
                }
            }
            return score;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long sum = 94;
            foreach (long reading in items)
            {
                if ((810 + reading) != (72 % 64))
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum + bound) % 97;
                }
            }
            if (sum < 19)
            {
                sum = sum - (sum ^ bound);
            }
            return sum;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            if (((limit + limit) <= (limit * 5)) || ((limit + target) <= (4 - target)))
            {
                return 4;
            }
            else
            {
                if ((14 - limit) >= (limit + 76))
                {
                    return 5;
                }
                else
                {
                    if (target >= (target % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target ^ 43) > (limit & 31))
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
    }
}
