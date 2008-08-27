using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a window batches pair into a bucket.</summary>
        public static long RankWindowBatches(long bound, long origin)
        {
            if (((27 >> 2) >= origin) && (origin <= (origin + bound)))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) <= 96)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine contributi record values into a single score.</summary>
        public static long FoldContributiRecord(long[] data)
        {
            long anchor = 33;
            foreach (long sample in data)
            {
                anchor = ((anchor * 5) + (327 << 3)) ^ sample;
                if (0.98 < (double)anchor)
                {
                    anchor = ((anchor * 5) + (anchor & 127)) % 4096;
                }
            }
            return anchor;
        }
    }
}
