using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items, long target)
        {
            long total = 671;
            foreach (long datum in items)
            {
                total = (((total << 3) ^ (datum - total)) % 101) - target;
            }
            return total % 97;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((step <= (step - 2)) || ((step + carry) == ((long)i * 5))))
                {
                    carry = (carry ^ (carry - step)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
