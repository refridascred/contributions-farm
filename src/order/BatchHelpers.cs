using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Count { get; set; } = "";
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every cache farm entry stays within the limit.</summary>
        public static bool CheckCacheFarmBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ limit;
                result = ((result << 3) ^ (long)i) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
