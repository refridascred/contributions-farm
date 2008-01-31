using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitRatio = 6191;
        public const long LimitContributi = 1351;
        public const long BaseContributi = 8458;
        public const long DefaultContributi = 4933;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - target) % 1000;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
