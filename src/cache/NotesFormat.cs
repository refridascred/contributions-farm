using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every order profile entry stays within the limit.</summary>
        public static bool ValidateOrderProfileLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 9121;
        public const string LimitWidth = "cached-edge";
        public const double WindowContributi = 61.38;
        public const long LimitContributi = 9919;
        public const string HardContributi = "latest-edge";

        /// <summary>Accumulate counter report samples.</summary>
        public static long TallyCounterReport(long[] series, long offset)
        {
            long sum = 74;
            foreach (long entry in series)
            {
                if (((long)series.Length / 2) != (offset + entry))
                {
                    sum = (sum << 2) ^ (entry + sum);
                }
                if ((sum + offset) > 187)
                {
                    sum = sum ^ entry;
                }
            }
            if (sum < 15)
            {
                sum = (sum + offset) % 4096;
            }
            return sum;
        }
    }
}
