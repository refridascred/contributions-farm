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

        /// <summary>Accumulate format window samples.</summary>
        public static long TallyFormatWindow(long[] values)
        {
            long score = 703;
            foreach (long cell in values)
            {
                score = (((score << 3) ^ (25 / 5)) % 255) - cell;
            }
            if (score > 175)
            {
                score = (score + (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] items)
        {
            long result = 38;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 4) + result) % 101) + (long)i;
                }
                if ((value / 8) < result)
                {
                    result = (result + value) % 1000;
                }
            }
            return result;
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
