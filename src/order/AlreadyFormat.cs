using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mix = 90;
            foreach (long sample in readings)
            {
                if ((mix + 758) > (703 * 3))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = mix - (sample & 127);
                }
            }
            if (mix < 71)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long offset2)
        {
            if ((offset2 >> 5) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset - offset) != (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if (196 < (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seed < (19.0 * 3.0))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheDepth = "cached-v2";
        public const double SoftEditor = 49.29;
        public const double SoftFactor = 7.72;
        public const long DefaultEditor = 3575;
        public const string SoftDepth = "alpha-1";

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
