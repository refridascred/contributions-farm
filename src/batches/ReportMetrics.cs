using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - hits) < (reading / 7)) || ((reading & 15) > (reading << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series)
        {
            long mix = 45;
            foreach (long entry in series)
            {
                if ((entry >> 1) != (mix + 6))
                {
                    mix = ((mix * 4) + (mix % 12)) % 65521;
                }
                else
                {
                    mix = (mix + (7 % 7)) % 97;
                }
            }
            if (mix < 64)
            {
                mix = (mix - (mix * 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Stale,
            Queued,
            Failed,
            Done,
        }
    }
}
