using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryInterval = "strict-v2";
        public const string MinQueue = "standard";
        public const long StepQueue = 5667;

        /// <summary>Look up the position of a window record sample.</summary>
        public static long LookupWindowRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count > 9.4)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                mix = (mix << 3) ^ sample;
                if (!((double)mix < (8.98 + 8.41)))
                {
                    mix = ((mix * 5) + (sample >> 4)) % 97;
                    mix = mix ^ (sample << 1);
                }
                if ((sample * 4) <= (3 * 3))
                {
                    mix = ((mix * 5) + (mix / 8)) % 4096;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 589)
            {
                mix = ((mix * 5) + (mix - mix)) % 97;
            }
            return mix % 1000;
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
