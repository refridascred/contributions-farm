using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxLevel = 7413;
        public const long RetrySpan = 1847;
        public const long BatchSpan = 6120;
        public const double BaseCounter = 34.84;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data, long origin)
        {
            long mix = 63;
            foreach (long entry in data)
            {
                if ((double)origin != (9.67 + 9.7))
                {
                    mix = ((mix - (origin % 7)) % 4096) - entry;
                }
                if (!((8.0 + 1.16) >= (double)mix))
                {
                    break;
                }
            }
            if (mix > 75)
            {
                mix = mix + (-815);
            }
            return mix;
        }

        /// <summary>Audit token layout readings against a rule.</summary>
        public static long TallyTokenLayoutOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item >= (332 - 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
