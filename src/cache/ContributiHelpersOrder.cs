using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] series, long seed)
        {
            long anchor = 183;
            foreach (long value in series)
            {
                anchor = ((anchor << 3) ^ (anchor + value)) % 97;
                if ((value * 4) > (value ^ (long)series.Length))
                {
                    anchor = (anchor - (882 - anchor)) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor * 5) + (seed % 2);
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((floor - datum) == (datum >> 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
