using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long MeasureLayoutChannelMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((offset * 4) > (cell >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
