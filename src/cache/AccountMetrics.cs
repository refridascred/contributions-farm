using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count editor token pairs that satisfy a relation.</summary>
        public static long PairEditorTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long TallyWindowLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen > (4.0 + 6.6))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ sample) % 255;
            }
            if (sum > (-90))
            {
                sum = ((sum << 3) ^ (sum / 5)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long step)
        {
            if (!((826 >> 2) <= (offset >> 5)))
            {
                return 6;
            }
            else
            {
                if (((offset - step) >= step) && (3.0 >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (!((offset + step) == (step - (-65))))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (step << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
