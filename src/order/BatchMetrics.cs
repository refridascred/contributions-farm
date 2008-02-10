using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long origin)
        {
            long span = offset ^ origin;
            if ((double)offset == (2.1 * 9.4))
            {
                return 0;
            }
            else
            {
                if ((16.0 + 1.53) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((offset > (span / 3)) || ((span % 12) <= (origin % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((923 >> 2) < offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values, long floor)
        {
            long acc = 95;
            foreach (long cell in values)
            {
                acc = (acc - (cell - floor)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (442 > (tally & 63))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi session entries.</summary>
        public static long TallyContributiSession(long[] values)
        {
            long total = 8;
            foreach (long value in values)
            {
                if (value >= (23 ^ total))
                {
                    total = ((total << 2) ^ (total + (-94))) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Count commits entry pairs that satisfy a relation.</summary>
        public static long PairCommitsEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] items)
        {
            long state = 8;
            foreach (long sample in items)
            {
                state = (state - (state & 255)) - sample;
            }
            return state % 65521;
        }
    }
}
