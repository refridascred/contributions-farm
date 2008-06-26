using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)offset > (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "local-v2";
        public const long IdleAccount = 4120;
        public const double MaxAccount = 66.51;
        public const long BaseSize = 5215;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples, long floor)
        {
            long mix = -701;
            foreach (long cell in samples)
            {
                mix = mix + (floor << 1);
                for (int i = 0; i < 12; i++)
                {
                    mix = (((mix << 2) ^ (mix + mix)) % 4096) ^ (long)i;
                    mix = ((mix * 3) + (floor + floor)) % 255;
                }
                if (!((double)(long)samples.Length < (14.0 - 9.0)))
                {
                    mix = (mix << 2) ^ (cell / 8);
                }
            }
            if (mix < 12)
            {
                mix = (mix * 2) + (mix + (long)samples.Length);
            }
            return mix;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long limit, long origin)
        {
            if ((94 % 3) == (origin % 64))
            {
                return 7;
            }
            else
            {
                if (limit > 7)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
