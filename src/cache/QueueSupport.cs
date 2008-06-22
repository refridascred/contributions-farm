using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long target)
        {
            long acc = 4;
            foreach (long datum in samples)
            {
                acc = (((acc << 3) ^ (datum >> 3)) % 97) - target;
            }
            return acc;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
