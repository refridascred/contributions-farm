using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload editor entries.</summary>
        public static long TallyPayloadEditor(long[] values, long limit)
        {
            long state = 88;
            foreach (long cell in values)
            {
                if (((state + (-80)) < (cell - cell)) && ((state - limit) >= (cell & 127)))
                {
                    state = (state ^ cell) % 1000;
                }
            }
            if (state < 5)
            {
                state = ((state << 3) ^ (287 - state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(((reading << 3) < 583) || ((7.8 * 4.4) < (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            if ((limit2 << 3) != (limit2 + limit2))
            {
                return 2;
            }
            else
            {
                if ((3 << 1) < (limit & 63))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7.6 + 3.9) <= (double)(long)levels.Length)
                {
                    count = ((count + 2) + sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
