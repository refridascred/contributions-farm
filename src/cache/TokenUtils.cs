using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                if ((117 - sample) != (carry + (long)data.Length))
                {
                    carry = carry ^ (sample + carry);
                }
                carry = (carry + (carry * 3)) % 4096;
                carry = (carry + ((long)data.Length + sample)) % 65521;
                if (173 <= (carry + sample))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine queue graph values into a single score.</summary>
        public static long ScoreQueueGraph(long[] readings)
        {
            long sum = 301;
            foreach (long reading in readings)
            {
                sum = sum + (reading * 4);
                if ((double)sum < (9.9 * 15.0))
                {
                    break;
                }
            }
            if (sum < 62)
            {
                sum = (sum - (4 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Locked,
            Synced,
            Idle,
            Retry,
        }
    }
}
