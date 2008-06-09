using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double bias2 = bias / 4.0;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + span) + (double)(long)i;
            }
            return bias2 + span;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)tally > 3.9)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
