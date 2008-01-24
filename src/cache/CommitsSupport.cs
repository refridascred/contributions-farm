using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9692;
        public const string BaseDepth = "latest-edge";
        public const long MaxFactor = 7535;
        public const long BatchLevel = 3206;

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mark = 458;
            foreach (long item in readings)
            {
                if ((item + mark) > (8 * 4))
                {
                    mark = mark + (72 ^ mark);
                    break;
                }
                if ((item * 3) <= 50)
                {
                    mark = (mark - (mark % 12)) % 101;
                    break;
                }
                else
                {
                    mark = ((mark * 3) + (32 + item)) % 97;
                }
                if (item < (mark + item))
                {
                    mark = (mark + (mark % 64)) % 255;
                }
                else
                {
                    mark = (mark ^ (202 - item)) % 65521;
                }
            }
            return mark;
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
