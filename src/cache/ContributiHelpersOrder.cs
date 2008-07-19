using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Stale,
            Draft,
            New,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window account readings against a rule.</summary>
        public static long MeasureWindowAccountHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((3.0 / 6.0) <= (double)seen))
                {
                    seen = ((seen + 3) - entry) - origin;
                }
            }
            return seen;
        }
    }
}
