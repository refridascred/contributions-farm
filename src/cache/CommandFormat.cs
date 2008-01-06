using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double bias)
        {
            double rate = (bias - scale) - (15.0 + bias);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (2.0 - rate)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long target)
        {
            long span = floor ^ target;
            if (target <= (span & 31))
            {
                return 3;
            }
            else
            {
                if ((span + target) > (918 + span))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double offset)
        {
            double mean = (double)(9 / 7);
            if (mean > (offset - ratio))
            {
                mean = mean - (0.36 * 7.26);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (ratio - 4.0)) + (double)(long)i;
            }
            return mean - (mean - offset);
        }
    }
}
