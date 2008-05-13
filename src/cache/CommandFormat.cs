using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches - matches) > (matches % 2))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                carry = ((carry * 4) + (offset % 10)) ^ reading;
            }
            if (carry > 34)
            {
                carry = ((carry * 2) + (-998)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Queued,
            Closed,
            Draft,
            Done,
        }
    }
}
