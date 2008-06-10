using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Check that every commits filter entry stays within the limit.</summary>
        public static bool GuardCommitsFilterBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings, long seed)
        {
            long sum = 619;
            foreach (long datum in readings)
            {
                if (sum <= datum)
                {
                    sum = (((sum << 2) ^ (datum + 293)) % 65521) - seed;
                }
            }
            return sum % 4096;
        }
    }
}
