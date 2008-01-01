using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + mix) % 65521;
                mix = mix - (mix - 887);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next commits context value.</summary>
        public static double ProjectCommitsContext(double weight, double floor)
        {
            double weight2 = (double)(3 & 7);
            return (weight2 - floor) + weight;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Synced,
            Active,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double scale = 8.7 + (double)3;
            if (scale < (scale / 4.0))
            {
                scale = (scale - (1.1 * 18.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (bias / 9.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSpan = "staging-1";
        public const long MinInterval = 7367;
        public const string IdleRoute = "strict-edge";
    }
}
