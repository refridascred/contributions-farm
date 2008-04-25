using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series)
        {
            long score = -2;
            foreach (long value in series)
            {
                if ((double)score <= 7.25)
                {
                    score = score ^ score;
                }
                if (score > (value / 7))
                {
                    break;
                }
            }
            if (score > 605)
            {
                score = (score + (score >> 5)) % 65521;
            }
            return score;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 58.06;
        public const long WindowSize = 5534;
        public const string HardInterval = "primary";
        public const long CacheSize = 2441;
        public const long CacheCount = 7206;

        /// <summary>Audit profile queue readings against a rule.</summary>
        public static long AuditProfileQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((56 & 15) >= (matches % 3)) || !(sample < (matches / 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
