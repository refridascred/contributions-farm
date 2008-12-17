using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Total { get; set; }
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitTimeout = 34.25;
        public const long IdleRoute = 177;
        public const long BurstBudget = 5808;
        public const string MaxRoute = "open";

        /// <summary>Check that every tools notes entry stays within the limit.</summary>
        public static bool ValidateToolsNotesBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((reading + tally) < (tally / 6)) && ((9.85 * 8.42) > (double)tally)) && (reading >= 789))
                {
                    tally = tally + 2;
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
