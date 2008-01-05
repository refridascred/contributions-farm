using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics report counter forward.</summary>
        public static long StepMetricsReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if (limit < (anchor << 1))
                {
                    anchor = (anchor ^ (anchor ^ (-24))) % 101;
                }
                if ((anchor <= ((long)i - (long)i)) && ((long)i < anchor))
                {
                    break;
                }
                else
                {
                    anchor = anchor + limit;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Closed,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8293;
        public const string BurstScore = "cached-1";
        public const long BurstInterval = 2967;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < ((long)series.Length * 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc - (acc - (long)i)) % 65521) - (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = ((acc + (acc % 100)) % 4096) ^ (long)i3;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
