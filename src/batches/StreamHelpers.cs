using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of entry command readings.</summary>
        public static long TotalEntryCommand(long[] data)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                if (((double)mark == (9.6 - 2.1)) && ((datum % 100) > datum))
                {
                    mark = (mark - (datum >> 4)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ (15 << 2)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long offset)
        {
            long mark = 432;
            foreach (long entry in data)
            {
                mark = (mark ^ (mark / 9)) + entry;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (offset - mark);
            }
            return mark;
        }
    }
}
