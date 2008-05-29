using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache layout readings against a rule.</summary>
        public static long AuditCacheLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (floor < (floor - hits))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two filter support measurements.</summary>
        public static double ProjectFilterSupport(double scale, double span)
        {
            double weight = (double)(8 + 6);
            if (weight >= weight)
            {
                weight = weight - (span + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Locked,
            Queued,
        }
    }
}
