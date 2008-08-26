using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long next = offset ^ step;
            if (!(next < (offset & 3)))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= 19.0)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value + value) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) != (tally ^ tally))
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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items)
        {
            long result = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = (((result * 2) + (value % 16)) % 97) - (long)i;
                }
                if ((result << 2) != (value + value))
                {
                    result = ((result << 3) ^ (result & 255)) % 255;
                }
                else
                {
                    result = (result * 2) + (value ^ result);
                }
            }
            return result;
        }
    }
}
