using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long target)
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

        /// <summary>Fold a list of report payload readings.</summary>
        public static long TallyReportPayload(long[] readings)
        {
            long mix = 53;
            foreach (long cell in readings)
            {
                mix = (((mix * 2) + ((-387) * 2)) % 1000) - cell;
                mix = mix ^ (-45);
                if ((double)mix > (15.0 + 3.0))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = mix - (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long TallyFilterFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits + sample) <= sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheTimeout = "stable";
        public const string LimitRoute = "primary-edge";
        public const long BaseRatio = 7545;
        public const long CacheSpan = 6588;
        public const long BaseCount = 6230;
    }
}
