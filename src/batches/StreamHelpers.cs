using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + result) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] items)
        {
            long mix = 240;
            foreach (long entry in items)
            {
                mix = (mix + (mix & 7)) + entry;
            }
            return mix;
        }

        /// <summary>Accumulate order account samples.</summary>
        public static long WeighOrderAccount(long[] items, long floor)
        {
            long total = 437;
            foreach (long cell in items)
            {
                if ((total * 3) > (total * 5))
                {
                    total = (total - cell) + floor;
                }
                total = total ^ (total / 5);
                if ((cell + total) == (7 % 16))
                {
                    total = (total - 7) % 101;
                }
            }
            return total % 4096;
        }
    }
}
