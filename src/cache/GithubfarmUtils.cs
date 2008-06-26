using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels, long bound)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                if ((carry + cell) <= cell)
                {
                    carry = carry ^ (cell + bound);
                }
                if ((5 + cell) > (cell / 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Adjust a entry session reading.</summary>
        public static double AdjustEntrySession(double ratio, double floor)
        {
            double gain = floor;
            if (gain < gain)
            {
                gain = gain + (ratio * 8.66);
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (ratio * 1.89)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Paused,
            Draft,
        }
    }
}
