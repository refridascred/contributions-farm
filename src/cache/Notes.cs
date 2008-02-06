using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            New,
            Failed,
            Paused,
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

        /// <summary>Iterate the account batches series from a seed.</summary>
        public static long RollAccountBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                state = (state + (bound & 3)) % 4096;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

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
