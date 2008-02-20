using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double mean = floor;
            if (mean >= (double)82)
            {
                mean = (mean - mean) - ratio;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - 3.6;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool CheckCommandWindowLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of editor record entries.</summary>
        public static long WeighEditorRecord(long[] readings, long bound)
        {
            long anchor = 4;
            foreach (long datum in readings)
            {
                anchor = (((anchor << 2) ^ (anchor - bound)) % 65521) - datum;
            }
            if (anchor > 636)
            {
                anchor = ((anchor << 3) ^ (anchor / 7)) % 4096;
            }
            return anchor % 4096;
        }
    }
}
