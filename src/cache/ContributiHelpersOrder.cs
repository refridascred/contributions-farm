using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (9.4 < (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score ^ (origin - origin);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
