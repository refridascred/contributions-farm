using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double bias, double bias2)
        {
            double scale = (bias / 7.0) / 7.0;
            if (scale < scale)
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (double)4;
        }

        /// <summary>Find the first entry order entry that matches the target.</summary>
        public static long SeekEntryOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
