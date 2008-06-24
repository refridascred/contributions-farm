using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double StepSession = 60.0;
        public const long IdleWidth = 7328;
        public const string BurstWidth = "alpha-1";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((double)reading <= (9.1 + 6.65)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long origin)
        {
            long mix = -3;
            foreach (long sample in values)
            {
                if ((mix < origin) || ((60 - sample) != (sample / 4)))
                {
                    mix = (mix ^ origin) % 255;
                }
                if (!((9.57 + 18.0) == (double)mix))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total - (seed + total)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
