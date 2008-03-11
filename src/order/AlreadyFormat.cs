using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count layout batches pairs that satisfy a relation.</summary>
        public static long PairLayoutBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((-9) + datum) == (datum << 2)) || ((double)tally == (5.9 / 5.0)))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] series, long origin)
        {
            long carry = 8;
            foreach (long item in series)
            {
                if (origin < (136 + origin))
                {
                    carry = ((carry << 3) ^ (origin - item)) % 4096;
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry * 2)) % 1000;
                }
                carry = (carry - (item - origin)) % 1000;
            }
            if (carry > 0)
            {
                carry = (carry - (carry % 24)) % 101;
            }
            return carry;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long origin, long offset)
        {
            long offset2 = origin + offset;
            if (offset2 < (offset & 3))
            {
                return 0;
            }
            else
            {
                if ((double)offset2 != (4.3 + 0.1))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset != (double)offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
