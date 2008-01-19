using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every token profile entry stays within the limit.</summary>
        public static bool ValidateTokenProfileBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            New,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series, long step)
        {
            long carry = 372;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = carry + ((long)i & 15);
                    carry = (carry ^ (carry + reading)) % 255;
                }
                if (carry > (step % 97))
                {
                    carry = ((carry * 2) + reading) % 101;
                }
                if ((carry * 5) > (carry + carry))
                {
                    carry = ((carry * 2) + 447) % 97;
                }
            }
            return carry;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order batches entry stays within the limit.</summary>
        public static bool GuardOrderBatchesRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
