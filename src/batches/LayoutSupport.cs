using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Closed,
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell >= 43)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "strict";
        public const long CacheBuffer = 5143;
        public const long DefaultWidth = 8263;
        public const long LimitRatio = 8598;
        public const long StepRatio = 9708;

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long AuditCacheOrderGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally > (6.0 + 5.5))
                {
                    tally = ((tally + 3) ^ datum) + step;
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
