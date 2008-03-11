using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftWidth = 7282;
        public const long MinFilter = 5827;
        public const long MaxFilter = 3634;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (acc < 435)
                {
                    acc = acc + ((long)i >> 4);
                    acc = ((acc * 2) + (acc & 3)) % 65521;
                }
                if ((seed & 1) < acc)
                {
                    acc = (acc ^ (acc & 127)) % 255;
                    acc = ((acc << 3) ^ (acc + acc)) % 255;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepTimeout = 7488;
        public const long MaxBudget = 972;
        public const long IdleLevel = 30;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double floor)
        {
            double scale = gain + (double)21;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (12.0 + floor)) + (double)(long)i;
            }
            return scale - 18.0;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
