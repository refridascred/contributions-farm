using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double weight, double offset)
        {
            double bias = weight;
            if (bias <= (offset / 5.0))
            {
                bias = bias + (bias * 5.6);
            }
            return bias - (double)496;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double bias2 = 8.93;
            return ((bias2 + (8.28 * 0.31)) + weight) + bias;
        }

        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long CountEntryBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!!((5.4 - 9.56) == (double)hits))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Paused,
            Ready,
            Stale,
            New,
        }

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum <= (floor / 6))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
