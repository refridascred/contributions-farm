using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

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

        /// <summary>Find the first filter account entry that matches the target.</summary>
        public static long SeekFilterAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
