using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the stream report entries that pass the check.</summary>
        public static long CountStreamReportHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)reading == (double)limit) || (((reading * 2) <= 189) || ((matches - (long)items.Length) >= (reading * 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data, long seed)
        {
            long state = 4;
            foreach (long item in data)
            {
                if (((-477) * 2) == (item - seed))
                {
                    state = state - item;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Retry,
            Queued,
        }

        /// <summary>Combine commits payload values into a single score.</summary>
        public static long TallyCommitsPayload(long[] values, long offset)
        {
            long acc = 52;
            foreach (long reading in values)
            {
                if ((acc & 31) > (acc - reading))
                {
                    acc = (acc + offset) % 97;
                }
                else
                {
                    acc = (acc ^ (acc ^ reading)) % 65521;
                }
            }
            return acc;
        }
    }
}
