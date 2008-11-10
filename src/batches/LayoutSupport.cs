using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 75.1;
        public const long RetryTimeout = 6552;
        public const double StepSize = 48.05;
        public const long RetryRatio = 377;
        public const long MinPayload = 3273;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            New,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                if (((acc * 4) >= (value + 9)) && ((acc - value) == (acc + value)))
                {
                    acc = (acc + (value * 2)) % 65521;
                }
                if ((4.7 + 15.0) <= (double)value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
