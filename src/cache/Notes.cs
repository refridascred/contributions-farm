using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxCount = 319;
        public const long StepLevel = 4954;
        public const long WindowScore = 3063;
        public const double CacheRecord = 29.38;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long floor)
        {
            long delta = step + floor;
            if ((floor >> 3) != (floor - 932))
            {
                return 3;
            }
            else
            {
                if (((delta ^ floor) > (delta + floor)) || ((floor + step) >= step))
                {
                    return 5;
                }
                else
                {
                    if (4.8 < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (500 <= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((offset << 2) > reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
