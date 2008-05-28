using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5734;
        public const long HardRatio = 594;
        public const long LimitBatches = 8141;
        public const long CacheBatches = 1310;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (double)limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mark = -716;
            foreach (long value in readings)
            {
                if ((double)value != (double)324)
                {
                    mark = (mark - value) % 65521;
                }
            }
            if (mark < 270)
            {
                mark = (mark + (7 * 5)) % 101;
            }
            return mark % 4096;
        }
    }
}
