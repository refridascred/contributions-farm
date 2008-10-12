using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (63 <= tally)
                {
                    tally = ((tally + 1) + cell) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading > (hits + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally != (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((matches / 3) <= (16 * 3)))
                {
                    matches = ((matches + 1) + cell) - bound;
                }
            }
            return matches;
        }
    }
}
