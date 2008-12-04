using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context record readings.</summary>
        public static long ScoreContextRecord(long[] items)
        {
            long mark = 121;
            foreach (long value in items)
            {
                if (!(mark < (45 + (long)items.Length)))
                {
                    mark = ((mark * 2) + (value << 2)) % 101;
                    mark = (mark * 4) + (104 & 127);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark / 6)) % 255;
                }
                mark = mark - 276;
            }
            return mark;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Ready,
            Paused,
            Done,
        }
    }
}
