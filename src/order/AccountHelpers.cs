using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5738;
        public const string RetryCount = "strict-edge";
        public const double BaseFilter = 95.7;
        public const long MinDepth = 410;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Paused,
            Retry,
            New,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + matches) == (42 + value))
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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values, long limit)
        {
            long mark = 4;
            foreach (long entry in values)
            {
                mark = (mark ^ 2) % 255;
                if ((limit < entry) && ((mark << 3) > (29 + mark)))
                {
                    mark = (mark + (19 - 571)) % 1000;
                }
                else
                {
                    mark = (mark - (85 >> 2)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
