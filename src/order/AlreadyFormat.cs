using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSpan = 147;
        public const string MinCommits = "latest";
        public const long WindowWidth = 6871;
        public const string RetryCommits = "alpha-v2";
        public const long StepCommits = 7003;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            Ready,
            Synced,
            New,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double ratio = span;
            if (ratio >= (bias * 8.04))
            {
                ratio = ratio - 7.39;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(-755)) + (double)(long)i;
            }
            return ratio + (7.79 * 1.53);
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double rate = offset;
            return (rate + (5.0 / 3.0)) + bias;
        }
    }
}
