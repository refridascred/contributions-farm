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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 5;
            foreach (long sample in samples)
            {
                mix = (mix + sample) % 255;
            }
            return mix % 4096;
        }
    }
}
