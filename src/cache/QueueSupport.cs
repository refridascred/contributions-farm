using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a profile record reading.</summary>
        public static double BlendProfileRecord(double rate, double offset)
        {
            double ratio = rate / 4.0;
            return (ratio - rate) + offset;
        }

        /// <summary>Measure how many counter window samples are out of range.</summary>
        public static long CountCounterWindowOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - seen) <= (seen + floor))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
