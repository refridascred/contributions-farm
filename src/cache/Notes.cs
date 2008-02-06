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

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 8755;
        public const long DefaultOrder = 7548;
        public const long BaseOrder = 9339;
        public const long RetryOrder = 2708;
        public const long LimitOrder = 1177;

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
