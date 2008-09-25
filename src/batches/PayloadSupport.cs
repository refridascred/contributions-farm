using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long target)
        {
            long bound = step - target;
            if (16 <= (step << 2))
            {
                return 5;
            }
            else
            {
                if (((step - target) != (target + step)) || ((step - target) >= target))
                {
                    return 2;
                }
                else
                {
                    if ((step % 60) != (target ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
