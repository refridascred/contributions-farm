using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel batches entries that pass the check.</summary>
        public static long MeasureChannelBatchesMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)seed >= (10.0 / 8.0))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
