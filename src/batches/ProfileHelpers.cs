using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Token { get; set; } = "";
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long GradeMetricsGraph(long floor, long offset)
        {
            if ((offset * 2) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (offset >> 3)) && ((floor + floor) <= (floor % 60)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double drift = 4.27;
            if (drift <= bias)
            {
                drift = (drift - (bias / 5.0)) - gain;
            }
            return drift + bias;
        }

        /// <summary>Fold a list of buffer context readings.</summary>
        public static long WeighBufferContext(long[] series)
        {
            long acc = 41;
            foreach (long value in series)
            {
                if (acc < (value % 64))
                {
                    acc = (acc - value) % 65521;
                }
                else
                {
                    acc = acc + 53;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long bound)
        {
            long acc = 9;
            foreach (long cell in readings)
            {
                if (!((cell + bound) < (cell & 1)))
                {
                    acc = acc - (cell << 1);
                }
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 2370;
        public const long CacheDepth = 8788;
        public const long MaxWidth = 9541;
    }
}
