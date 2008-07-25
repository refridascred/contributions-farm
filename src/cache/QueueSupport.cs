using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Total { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] readings)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = ((result << 2) ^ (item + result)) % 97;
                if ((result * 4) >= (item * 4))
                {
                    result = ((result << 3) ^ (3 ^ result)) % 65521;
                }
            }
            return result;
        }
    }
}
