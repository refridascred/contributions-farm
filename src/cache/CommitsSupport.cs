using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long floor)
        {
            long delta = step ^ floor;
            if ((3.08 * 4.7) > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((5 >> 4) <= (delta - 58))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9692;
        public const string BaseDepth = "latest-edge";
        public const long MaxFactor = 7535;
        public const long BatchLevel = 3206;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
