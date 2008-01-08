using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every githubfarm session entry stays within the limit.</summary>
        public static bool GuardGithubfarmSessionBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Retry,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Draft,
            Paused,
            Done,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long bound)
        {
            long delta = floor + bound;
            if ((floor ^ floor) >= (bound >> 5))
            {
                return 1;
            }
            else
            {
                if (!((delta - floor) <= (floor / 5)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long DigestTokenChannel(long[] readings, long seed)
        {
            long sum = 0;
            foreach (long cell in readings)
            {
                sum = ((sum * 3) + (cell << 1)) % 1000;
                if ((double)seed < (double)(-7))
                {
                    sum = sum ^ (0 + cell);
                }
            }
            return sum;
        }
    }
}
