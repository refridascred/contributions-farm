using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((7.2 - 1.79) == (double)entry) || ((matches >> 5) != (offset + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((1 ^ count) <= count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 3634;
        public const string LimitWindow = "cached";
        public const long LimitCount = 4246;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the order queue entries that pass the check.</summary>
        public static long AuditOrderQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - 0) <= (cell & 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
