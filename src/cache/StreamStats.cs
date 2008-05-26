using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double bias)
        {
            double scale = (double)((-9) - 90);
            return (scale + rate) + bias;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Paused,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if (!(sum < (sample / 6)))
                {
                    sum = sum - (sum << 3);
                }
                else
                {
                    sum = (sum + sample) % 255;
                }
            }
            if (sum < 6)
            {
                sum = (sum - (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the contributi batch entries that pass the check.</summary>
        public static long TallyContributiBatchMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (tally % 2))
                {
                    tally = ((tally + 3) - value) - target;
                }
            }
            return tally;
        }
    }
}
