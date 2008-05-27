using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double weight = floor;
            if (weight <= (floor / 7.0))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (floor / 5.0)) - (double)(long)i;
            }
            return weight + (weight + bias);
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)bound > (8.6 + 5.25)))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
