using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 8932;
        public const long BurstSchema = 8296;
        public const double WindowScore = 33.37;
        public const long WindowTimeout = 7490;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((bound >> 2) == (reading >> 4)) && ((reading + bound) > hits)) && ((reading / 5) >= bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
