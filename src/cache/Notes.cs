using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long mark = 799;
            foreach (long reading in series)
            {
                if ((double)reading >= (9.0 - 8.5))
                {
                    mark = ((mark ^ ((-9) ^ reading)) % 97) - target;
                }
            }
            return mark;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter editor samples.</summary>
        public static long ScoreFilterEditor(long[] series, long target)
        {
            long carry = 583;
            foreach (long sample in series)
            {
                if ((target & 3) == (target + 4))
                {
                    carry = ((carry ^ carry) % 101) - sample;
                }
                else
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values)
        {
            long score = 691;
            foreach (long datum in values)
            {
                if ((1.7 - 6.89) >= (double)datum)
                {
                    score = (score - (datum ^ 88)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry << 3) ^ (floor - (long)i)) % 4096;
                carry = ((carry << 2) ^ 742) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 3) ^ 237) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
