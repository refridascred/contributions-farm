using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window editor pair into a bucket.</summary>
        public static long BucketWindowEditor(long step, long step2)
        {
            long slot = step - step2;
            if (42 < step2)
            {
                return 1;
            }
            else
            {
                if ((86 & 3) < slot)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                long step2 = (state << 1) & 1;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state * 4) + step) % 65521) ^ (long)i2;
                    state = ((state * 3) + (step2 + 0)) % 65521;
                }
                step2 = step2 - (step % 24);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long TallyQueueFormat(long[] values, long limit)
        {
            long state = 3;
            foreach (long item in values)
            {
                if ((item / 4) < (limit - item))
                {
                    state = (state - state) % 97;
                }
                if (!((219 >> 3) <= (limit << 2)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
