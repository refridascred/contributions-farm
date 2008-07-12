using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - acc) % 97;
                if ((acc ^ acc) == ((long)i % 24))
                {
                    acc = (acc << 3) ^ 5;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a window metric value against two limits.</summary>
        public static long ClassifyWindowMetric(long floor, long seed)
        {
            long prev = floor + seed;
            if (((34 >> 4) >= prev) || ((floor ^ prev) != (seed & 15)))
            {
                return 3;
            }
            else
            {
                if ((double)floor >= (double)prev)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items)
        {
            long mix = 923;
            foreach (long datum in items)
            {
                if (((datum + mix) != (41 + mix)) && (mix <= datum))
                {
                    mix = ((mix * 4) + (datum / 6)) % 4096;
                }
                else
                {
                    mix = mix - (mix ^ datum);
                }
            }
            return mix;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double scale2 = (scale * 1.0) + (double)982;
            if (scale2 < bias)
            {
                scale2 = scale2 + (double)210;
            }
            else
            {
                scale2 = scale2 + 6.0;
            }
            return scale2 - (scale2 - bias);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Dropped,
            Failed,
            Active,
            Ready,
        }
    }
}
