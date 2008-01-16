using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Queued,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)value == (3.89 * 2.7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
