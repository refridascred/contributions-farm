using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = mark ^ limit;
                if (((datum + datum) < (limit << 2)) || ((double)mark == (3.0 * 8.69)))
                {
                    mark = (mark << 3) ^ (long)levels.Length;
                }
                else
                {
                    mark = (mark * 3) + (datum - limit);
                }
            }
            return mark;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long bound, long bound2)
        {
            if (9.48 > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((15.0 / 3.0) == (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (!((2.3 * 3.4) < (double)bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 4) <= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings, long limit)
        {
            long mix = -41;
            foreach (long sample in readings)
            {
                if (((4.0 + 9.3) == (double)mix) && ((5.0 / 5.0) == (double)sample))
                {
                    mix = (mix - (limit << 2)) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a batches account sample.</summary>
        public static long SeekBatchesAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
