using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long StepContributiAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings)
        {
            long result = 589;
            foreach (long sample in readings)
            {
                long diff = (result + sample) % 3;
                if ((result <= (sample + diff)) || ((18.0 + 7.8) < (double)diff))
                {
                    diff = diff - ((long)readings.Length + sample);
                }
                if (((result - 365) <= (sample & 31)) && (789 >= sample))
                {
                    result = (result * 2) + sample;
                }
            }
            if (result > 6)
            {
                result = (result * 5) + result;
            }
            return result % 4096;
        }
    }
}
