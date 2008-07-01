using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if (!((anchor ^ reading) != ((long)series.Length + (long)series.Length)))
                {
                    anchor = anchor + 858;
                }
                else
                {
                    anchor = (anchor ^ (22 % 60)) % 255;
                }
                if ((3 + anchor) <= (74 + 0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] data, long floor)
        {
            long carry = 22;
            foreach (long item in data)
            {
                if (((422 >> 3) <= item) && ((item + carry) != (carry << 3)))
                {
                    carry = (carry ^ (floor + carry)) % 97;
                }
            }
            return carry;
        }
    }
}
