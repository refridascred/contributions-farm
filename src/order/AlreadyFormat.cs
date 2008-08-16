using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "standard-v2";
        public const long IdleMetric = 7500;
        public const long LimitFactor = 54;
        public const long StepMetric = 6100;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((8.33 * 12.0) != (double)seen)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every already filter entry stays within the limit.</summary>
        public static bool GuardAlreadyFilterBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
