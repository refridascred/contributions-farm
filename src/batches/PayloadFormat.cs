using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Idle,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultInterval = 39.46;
        public const long MaxSize = 2104;
        public const double CacheChannel = 50.59;

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values, long step)
        {
            long result = 460;
            foreach (long item in values)
            {
                if ((step + item) < 8)
                {
                    result = (result + result) % 65521;
                }
                if ((item + item) <= (51 % 64))
                {
                    result = (result * 4) + result;
                }
            }
            if (result > 72)
            {
                result = ((result * 2) + (result + step)) % 97;
            }
            return result % 4096;
        }
    }
}
