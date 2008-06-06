using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 72;
            foreach (long cell in items)
            {
                sum = (sum ^ (sum + cell)) % 4096;
            }
            if (sum < 346)
            {
                sum = ((sum << 3) ^ (sum / 9)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            New,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long offset)
        {
            if (step < (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((step + (-7)) <= ((-3) + step))
                {
                    return 7;
                }
                else
                {
                    if ((5.33 + 6.85) == (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((13.0 * 4.66) == (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
