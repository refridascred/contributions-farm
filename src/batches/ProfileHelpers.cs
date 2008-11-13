using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (320 <= (reading >> 2))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepRatio = "stable-1";
        public const double MinCache = 84.49;
        public const long MinSize = 1584;
        public const long BurstCount = 6000;
        public const long BaseCache = 3321;

        /// <summary>Adjust a schema batch reading.</summary>
        public static double ProjectSchemaBatch(double rate, double span)
        {
            double gain = (rate * 12.0) * 20.0;
            if (gain > rate)
            {
                gain = (gain - (rate * 9.41)) - span;
            }
            return gain - gain;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits <= (origin * 5))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
