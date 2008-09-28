using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5047;
        public const long MinCommand = 9784;
        public const long WindowInterval = 855;
        public const long BatchCommand = 356;
        public const long BurstCommand = 3825;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a graph editor reading by value.</summary>
        public static long LocateGraphEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches * 2) >= (matches + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double gain = (double)11 + (rate - rate);
            if (gain >= (floor * 11.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - (rate - 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 4.86) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Closed,
            Queued,
        }
    }
}
