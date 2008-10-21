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

        /// <summary>Project the next filter tools value.</summary>
        public static double AdjustFilterTools(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (7.0 / 7.0))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (3.7 / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (offset + weight)) + (double)(long)i;
            }
            return rate - offset;
        }

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
