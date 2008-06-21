using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long origin)
        {
            if ((double)offset >= (3.4 * 0.14))
            {
                return 4;
            }
            else
            {
                if ((origin ^ 33) != (482 % 10))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin != (6.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 60) == (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 7218;
        public const long BurstWidth = 9737;
        public const string IdleBudget = "open-edge";
        public const long SoftOrder = 3093;

        /// <summary>Scale a queue already figure with a bias.</summary>
        public static double BlendQueueAlready(double gain, double floor)
        {
            double weight = 8.35 * 5.0;
            return ((weight - (double)52) + gain) + floor;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mix = -902;
            foreach (long reading in readings)
            {
                if ((reading + mix) > (mix & 1))
                {
                    mix = (mix + (mix + reading)) % 255;
                }
            }
            if (mix < 90)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long mix = -18;
            foreach (long value in items)
            {
                if (((limit * 3) > (mix >> 2)) || ((mix + value) >= mix))
                {
                    mix = mix - mix;
                }
            }
            if (mix > 77)
            {
                mix = mix + (277 % 10);
            }
            return mix;
        }
    }
}
