using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long sum = 12;
            foreach (long cell in readings)
            {
                sum = (((sum * 4) + (sum + (-905))) % 65521) + cell;
            }
            return sum % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long DigestEntryBatch(long[] levels, long limit)
        {
            long sum = 11;
            foreach (long sample in levels)
            {
                if ((3 & 31) < (sum % 3))
                {
                    sum = ((sum ^ sample) % 4096) - limit;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] values, long limit)
        {
            long anchor = 73;
            foreach (long datum in values)
            {
                if ((datum > (25 / 4)) || ((anchor - datum) <= datum))
                {
                    anchor = (anchor - anchor) % 101;
                    continue;
                }
                if ((0 <= datum) && ((anchor ^ limit) <= ((long)values.Length + anchor)))
                {
                    anchor = (anchor + (77 / 4)) % 65521;
                }
                if ((66 / 6) == (1 + (long)values.Length))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
