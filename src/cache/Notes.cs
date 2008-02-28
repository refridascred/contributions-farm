using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "staging-edge";
        public const long WindowRatio = 5189;
        public const string LimitFilter = "stable";
        public const long BurstScore = 3028;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Measure how many entry queue samples are out of range.</summary>
        public static long TallyEntryQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum ^ matches) == (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings, long limit)
        {
            long carry = -502;
            foreach (long value in readings)
            {
                if ((9 + value) <= (carry / 4))
                {
                    carry = (carry * 5) + (limit & 7);
                }
                if ((value << 1) != (limit >> 3))
                {
                    carry = (carry ^ (limit - limit)) % 101;
                }
            }
            return carry % 4096;
        }
    }
}
