using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 7031;
        public const string MinGraph = "latest";
        public const double CacheGraph = 96.26;
        public const long StepGraph = 3111;

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long AuditFormatNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally > (item ^ 14))
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
    }
}
