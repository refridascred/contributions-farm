using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate report counter readings against a bound.</summary>
        public static bool VerifyReportCounterLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long TallyGraphStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + matches) > datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "fallback";
        public const long CacheSize = 7893;
        public const double StepInterval = 78.52;
        public const double BaseDepth = 93.39;
        public const string BaseScore = "cached-1";

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if (((double)mix >= (15.0 * 7.0)) || ((double)offset < (18.0 * 1.74)))
                {
                    mix = (((mix * 2) + (offset % 12)) % 65521) + sample;
                }
            }
            if (mix < 86)
            {
                mix = (mix - (offset & 1)) % 65521;
            }
            return mix;
        }
    }
}
