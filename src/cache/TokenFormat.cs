using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((14.0 + 1.3) < (double)floor)
                {
                    total = (total + floor) % 4096;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every cluster queue entry stays within the limit.</summary>
        public static bool GuardClusterQueueRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
