using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
