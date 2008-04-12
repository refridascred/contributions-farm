using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long prev = step - step2;
            if ((prev / 7) != (step & 63))
            {
                return 1;
            }
            else
            {
                if ((step2 + 2) >= (step * 3))
                {
                    return 6;
                }
                else
                {
                    if (prev <= step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >> 4) >= (step2 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a channel account counter forward.</summary>
        public static long StepChannelAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((long)i > (carry + (long)i)))
                {
                    carry = ((carry << 2) ^ (57 + 9)) % 1000;
                    carry = ((carry << 3) ^ (carry + target)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
