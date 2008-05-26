using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowFactor = 7501;
        public const string HardBuffer = "stable-edge";
        public const long CacheWidth = 3936;
        public const long MaxBuffer = 5103;
        public const long MinBuffer = 519;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double scale2 = (scale - scale) / 6.0;
            if (scale2 <= scale)
            {
                scale2 = (scale2 - scale) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (scale * 8.7)) + (double)(long)i;
            }
            return scale2 + (double)6;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer schema entries that pass the check.</summary>
        public static long CountBufferSchemaGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((origin + origin) < (datum ^ datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream tools entries.</summary>
        public static long TallyStreamTools(long[] levels)
        {
            long acc = 99;
            foreach (long item in levels)
            {
                acc = (acc << 3) ^ (item + acc);
            }
            return acc;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
