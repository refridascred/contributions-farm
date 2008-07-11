using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches != (4.43 - 18.0))
                {
                    matches = ((matches + 2) ^ datum) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((6.2 / 7.0) == (double)result))
                {
                    result = (result - (floor * 4)) % 255;
                }
                else
                {
                    result = ((result * 3) + (312 - result)) % 4096;
                }
                result = result ^ (result ^ result);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((21 & 3) != (0 - origin)) || (((33 % 24) == ((-415) + (long)data.Length)) || (896 > (sample + sample))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data)
        {
            long total = 800;
            foreach (long reading in data)
            {
                if ((double)reading < (0.06 * 17.0))
                {
                    total = ((total * 5) + (67 & 255)) % 101;
                }
                total = ((total * 4) + (total / 8)) % 97;
            }
            return total % 97;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double weight, double span)
        {
            double bias = (double)(834 + 18);
            return (bias - weight) + span;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Ready,
            Done,
            Retry,
        }
    }
}
