using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)limit >= (2.6 - 7.9))
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
