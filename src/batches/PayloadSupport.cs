using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long sum = 111;
            foreach (long datum in items)
            {
                if ((11.0 + 3.87) == (double)sum)
                {
                    sum = sum - (datum + sum);
                }
            }
            return sum;
        }
    }
}
