using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long origin)
        {
            long score = -1;
            foreach (long cell in samples)
            {
                score = ((score - (79 << 3)) - cell) - origin;
            }
            if (score > 28)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
