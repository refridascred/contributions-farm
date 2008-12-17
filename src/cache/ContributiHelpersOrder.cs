using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long total = 446;
            foreach (long sample in levels)
            {
                total = (total + 50) % 65521;
                if (((sample - 251) > sample) && (sample < total))
                {
                    total = (total ^ sample) % 4096;
                }
            }
            if (total > 288)
            {
                total = (total ^ total) % 1000;
            }
            return total % 97;
        }
    }
}
