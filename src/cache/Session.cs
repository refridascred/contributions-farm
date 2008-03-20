using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((long)series.Length > (107 + item)) && (((item * 2) > (seen ^ item)) && ((seen - item) < (seen % 10))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long result = -72;
            foreach (long value in data)
            {
                result = (result + (value * 3)) % 101;
                result = ((result * 2) + (result >> 1)) % 65521;
                result = result + (result + 673);
            }
            return result;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
