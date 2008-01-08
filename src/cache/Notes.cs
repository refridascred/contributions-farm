using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - entry) < entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two format cluster measurements.</summary>
        public static double BlendFormatCluster(double scale, double floor)
        {
            double drift = floor;
            if (drift < (scale * 17.0))
            {
                drift = drift - (scale / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor - 9.0)) + (double)(long)i;
            }
            return drift + 11.0;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((4.03 * 4.65) >= (double)count) || ((double)(long)readings.Length != (8.56 - 4.2)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Locate a layout payload reading by value.</summary>
        public static long SeekLayoutPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
