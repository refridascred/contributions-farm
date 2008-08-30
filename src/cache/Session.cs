using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Idle,
            New,
            Queued,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double bias, double span)
        {
            double bias2 = span;
            return (bias2 - span) + bias;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches * 5) > (sample + matches))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (origin >= (origin + origin))
                {
                    tally = (tally + 3) + entry;
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
