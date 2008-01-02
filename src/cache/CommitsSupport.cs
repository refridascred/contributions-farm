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

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            New,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Derive the next format payload value from a seed.</summary>
        public static long IterateFormatPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                if (origin > total)
                {
                    long matches = total;
                    total = ((total << 2) ^ (origin - matches)) % 4096;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double ratio, double offset)
        {
            double bias = (double)35 / 2.0;
            if (bias >= bias)
            {
                bias = ((bias + (double)(-59)) + ratio) - offset;
            }
            return bias - bias;
        }
    }
}
