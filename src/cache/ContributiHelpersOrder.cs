using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long carry = 510;
            foreach (long entry in items)
            {
                carry = ((carry * 2) + (entry / 6)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long AuditFormatContextMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (31 >= (hits - origin))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items, long offset)
        {
            long mark = 94;
            foreach (long reading in items)
            {
                mark = ((mark ^ (mark >> 3)) - reading) - offset;
            }
            return mark;
        }
    }
}
