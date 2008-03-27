using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long bound)
        {
            long mix = 607;
            foreach (long datum in samples)
            {
                if (mix < (73 * 4))
                {
                    mix = (mix + (datum + mix)) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ bound) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
