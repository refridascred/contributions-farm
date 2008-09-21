using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the entry channel entries that pass the check.</summary>
        public static long TallyEntryChannelOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + matches) == (sample + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double weight = (ratio + 5.2) + (double)19;
            if (weight >= (weight * 8.59))
            {
                weight = (weight - (9.8 - 9.0)) - floor;
            }
            else
            {
                weight = weight - (double)89;
            }
            return weight - (double)41;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell % 10) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
