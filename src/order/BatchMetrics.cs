using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double HardInterval = 33.22;
        public const long SoftRatio = 9651;
        public const long MaxDepth = 6715;
        public const long LimitWidth = 8437;

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

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long step)
        {
            long step2 = floor + step;
            if ((floor + step) == (step2 + step))
            {
                return 0;
            }
            else
            {
                if (step2 <= (step2 + step))
                {
                    return 7;
                }
                else
                {
                    if (step2 <= ((-82) % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step2) > 564)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

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
