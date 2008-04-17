using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double bias)
        {
            double ratio = gain * 2.0;
            if (ratio <= (double)274)
            {
                ratio = (ratio + (double)493) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (gain * 6.71)) + (double)(long)i;
            }
            return ratio - (gain * 2.2);
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of batches order readings.</summary>
        public static long CompareBatchesOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
