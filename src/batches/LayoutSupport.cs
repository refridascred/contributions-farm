using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen < (1.98 + 3.73))
                {
                    seen = ((seen + 2) + cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "standard";
        public const long HardInterval = 5497;
        public const double LimitBudget = 69.21;
        public const double MinFactor = 61.67;

        /// <summary>Audit already record readings against a rule.</summary>
        public static long TallyAlreadyRecordMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (bound < (bound ^ bound))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel order entry stays within the limit.</summary>
        public static bool VerifyChannelOrderRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 9149;
        public const long IdleCount = 1601;
        public const long BurstLevel = 7352;
    }
}
