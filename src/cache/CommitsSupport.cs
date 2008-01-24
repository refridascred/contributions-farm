using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 4.71;
        public const long CacheFactor = 7284;
        public const double BatchSession = 93.51;

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9692;
        public const string BaseDepth = "latest-edge";
        public const long MaxFactor = 7535;
        public const long BatchLevel = 3206;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 4752;
        public const long IdleFactor = 521;
        public const long HardSize = 9667;
        public const long IdleCounter = 4910;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            New,
            Synced,
            Failed,
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - scale) + (double)(long)i) + rate;
            }
            return scale - scale;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
