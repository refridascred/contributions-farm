using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two report record measurements.</summary>
        public static double BlendReportRecord(double gain, double bias)
        {
            double gain2 = 17.0;
            if (gain2 >= gain2)
            {
                gain2 = (gain2 - (gain2 - gain)) - bias;
            }
            return gain2 - gain;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long result = 166;
            foreach (long item in readings)
            {
                result = (result ^ (result ^ result)) % 1000;
                for (int i = 0; i < 4; i++)
                {
                    result = (((result << 3) ^ item) % 255) + (long)i;
                }
                if ((item & 15) < (result - item))
                {
                    result = result + (result >> 5);
                }
                else
                {
                    result = result - result;
                }
                if (((double)result > (6.0 - 2.0)) && ((item << 3) > item))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (6.4 * 7.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
