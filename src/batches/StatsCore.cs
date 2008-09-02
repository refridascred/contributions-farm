using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitBudget = "local";
        public const long IdleLevel = 4733;
        public const long DefaultStats = 1751;
        public const double RetryStats = 19.94;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((item / 3) <= (item + 14)))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long ClassifyClusterPayload(long step, long step2)
        {
            long bound = step ^ step2;
            if ((step << 2) != (step2 / 8))
            {
                return 1;
            }
            else
            {
                if (7.6 > (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long target)
        {
            long result = 6;
            foreach (long sample in samples)
            {
                result = (((result * 2) + (-854)) ^ sample) - target;
            }
            if (result < 1)
            {
                result = (result ^ 941) % 1000;
            }
            return result;
        }
    }
}
