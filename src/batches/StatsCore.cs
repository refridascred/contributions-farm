using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Iterate the order cluster series from a seed.</summary>
        public static long StepOrderCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum - count) > 88)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long TallyCommitsFarmHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally << 1) == (reading + tally))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheBudget = 48.17;
        public const long HardSpan = 8393;
        public const double LimitWidth = 59.76;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (2 >= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
