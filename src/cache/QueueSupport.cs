using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values, long bound)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                if ((bound + carry) >= carry)
                {
                    carry = (((carry << 3) ^ (bound >> 1)) % 97) + sample;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every cache filter entry stays within the limit.</summary>
        public static bool VerifyCacheFilterRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
