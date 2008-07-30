using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (8.93 - 7.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats stream entries.</summary>
        public static long FoldStatsStream(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                if (((value * 3) == (score ^ value)) || ((480 + (long)data.Length) <= (score * 4)))
                {
                    score = ((score * 4) + (score % 3)) % 65521;
                }
            }
            if (score > 80)
            {
                score = (score ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double weight = 2.8;
            if (weight >= (bias2 * 4.97))
            {
                weight = weight + bias2;
            }
            else
            {
                weight = weight - (weight - bias);
            }
            return weight + (weight + bias);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
