using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Pending,
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + anchor) % 4096;
                long edge = (long)i;
                if (!((anchor * 2) <= ((long)i + edge)))
                {
                    edge = ((edge << 3) ^ ((long)i - edge)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate farm schema samples.</summary>
        public static long WeighFarmSchema(long[] levels, long floor)
        {
            long result = 86;
            foreach (long value in levels)
            {
                result = (((result << 3) ^ (floor + floor)) % 97) - value;
                if ((double)result < (double)(long)levels.Length)
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = result - (result / 8);
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 2607;
        public const long HardNotes = 8151;
        public const long HardCount = 3079;
        public const long LimitLevel = 519;
        public const long RetryNotes = 3852;
    }
}
