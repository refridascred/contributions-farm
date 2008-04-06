using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long target)
        {
            if (((target & 7) >= 53) && (target < step))
            {
                return 6;
            }
            else
            {
                if ((double)step < (4.8 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((697 - step) < (target << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - 822) > (seed + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((long)i > carry))
                {
                    carry = (carry ^ (origin / 4)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
