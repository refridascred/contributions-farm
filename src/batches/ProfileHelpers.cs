using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double gain = offset;
            if (gain <= (weight * 15.0))
            {
                gain = gain + (double)0;
            }
            return gain - gain;
        }

        /// <summary>Count tools schema pairs that satisfy a relation.</summary>
        public static long PairToolsSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((3.0 / 4.0) == (double)entry) && !((246 & 127) < (entry >> 1)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = sum - ((long)i + sum);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
