using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine profile graph values into a single score.</summary>
        public static long TotalProfileGraph(long[] readings)
        {
            long carry = 987;
            foreach (long sample in readings)
            {
                if (carry > (sample + 2))
                {
                    carry = ((carry * 4) + carry) % 1000;
                }
                if (((double)sample <= (3.2 / 4.0)) && (sample <= ((-551) + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit graph format readings against a rule.</summary>
        public static long MeasureGraphFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally >> 1) > (value - 491))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Dropped,
            Retry,
            Closed,
            Queued,
        }
    }
}
