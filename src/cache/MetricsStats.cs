using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long mix = 721;
            foreach (long cell in readings)
            {
                if ((cell * 2) < mix)
                {
                    mix = mix ^ (mix / 4);
                }
            }
            return mix;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double floor)
        {
            double mean = floor;
            if (mean > (mean / 4.0))
            {
                mean = (mean - 16.0) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.7) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Paused,
            Closed,
            Pending,
            Active,
        }
    }
}
