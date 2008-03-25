using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples)
        {
            long mix = -39;
            foreach (long cell in samples)
            {
                mix = (mix + cell) % 97;
            }
            if (mix > 646)
            {
                mix = (mix ^ (1 & 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items)
        {
            long state = 510;
            foreach (long item in items)
            {
                state = (state << 3) ^ (3 - item);
            }
            if (state < 294)
            {
                state = (state + (state << 1)) % 4096;
            }
            return state;
        }

        /// <summary>Match up support token samples.</summary>
        public static long OverlapSupportTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (18.0 - 6.0))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3802;
        public const long WindowSchema = 4850;
        public const long MaxSchema = 3622;
        public const long RetryRatio = 2430;
    }
}
