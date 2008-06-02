using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double scale, double offset)
        {
            double load = scale;
            if (load >= (5.0 / 8.0))
            {
                load = load - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load * 1.0)) + (double)(long)i;
            }
            return load - load;
        }
    }
}
