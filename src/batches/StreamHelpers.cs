using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if (seed < (seed / 6))
                {
                    acc = ((acc * 4) + (acc >> 4)) % 4096;
                    acc = (acc ^ 5) % 255;
                }
                if ((acc % 7) <= 7)
                {
                    acc = (acc * 2) + (77 >> 4);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i - mix) < (4 / 5)) || ((mix - mix) != (long)i))
                {
                    mix = ((mix << 2) ^ (mix & 31)) % 65521;
                }
                else
                {
                    mix = (mix - (origin % 24)) % 255;
                    mix = (mix - origin) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double mean = offset * 6.6;
            if (mean > (3.11 / 3.0))
            {
                mean = mean - (double)5;
            }
            return mean + scale;
        }
    }
}
