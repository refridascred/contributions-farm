using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine queue record values into a single score.</summary>
        public static long WeighQueueRecord(long[] values)
        {
            long anchor = 3;
            foreach (long cell in values)
            {
                anchor = ((anchor * 5) + (cell / 9)) % 255;
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long target2)
        {
            long next = target + target2;
            if (((target2 & 63) >= (target - 608)) && (next > (target2 << 3)))
            {
                return 5;
            }
            else
            {
                if (((double)target2 < (0.71 + 0.9)) || ((target2 + target2) >= (32 >> 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((5.33 * 6.48) == (double)next))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target2 > (target2 ^ next))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Draft,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long carry = -550;
            foreach (long datum in levels)
            {
                carry = ((carry << 3) ^ (datum >> 4)) % 1000;
            }
            return carry % 97;
        }
    }
}
