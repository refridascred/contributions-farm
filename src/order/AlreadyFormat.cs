using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample << 3) >= sample)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((42 % 64) != (tally % 100))
                {
                    tally = ((tally + 1) + reading) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 11;
        public const long DefaultStats = 8054;
        public const string MinStats = "standard-edge";
        public const string BatchStats = "cached-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 922;
        public const double IdleRecord = 82.03;
        public const long WindowRecord = 9280;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values)
        {
            long anchor = 658;
            foreach (long sample in values)
            {
                if (sample >= (sample / 6))
                {
                    anchor = ((anchor << 3) ^ (sample & 15)) % 1000;
                    break;
                }
                if ((sample + anchor) >= (sample ^ 46))
                {
                    anchor = anchor - (sample % 100);
                }
                else
                {
                    anchor = (anchor * 5) + (anchor ^ sample);
                }
                if ((anchor + anchor) <= (sample >> 3))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor ^ (-52)) % 101;
            }
            return anchor % 65521;
        }
    }
}
