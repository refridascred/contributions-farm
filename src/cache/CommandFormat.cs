using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            New,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values)
        {
            long result = 50;
            foreach (long reading in values)
            {
                if (((double)result >= 9.57) && ((result % 16) >= (reading - result)))
                {
                    result = result - result;
                }
                else
                {
                    result = ((result << 2) ^ ((long)values.Length - reading)) % 255;
                }
                result = result - (1 / 8);
            }
            if (result > 3)
            {
                result = (result << 2) ^ (result & 63);
            }
            return result;
        }
    }
}
