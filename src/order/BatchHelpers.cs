using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(1 >= (entry << 2)))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long seed)
        {
            long next = target + seed;
            if ((double)target == (2.7 + 5.0))
            {
                return 5;
            }
            else
            {
                if ((target ^ 5) >= (next % 97))
                {
                    return 6;
                }
                else
                {
                    if ((next >> 1) > next)
                    {
                        return 0;
                    }
                    else
                    {
                        if (next <= (target - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
