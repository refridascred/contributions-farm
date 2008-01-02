using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double span)
        {
            double drift = 4.81 / 2.0;
            return ((drift - drift) + rate) + span;
        }

        /// <summary>Fold a list of command already readings.</summary>
        public static long FoldCommandAlready(long[] readings, long offset)
        {
            long result = 49;
            foreach (long item in readings)
            {
                if ((result * 4) < (item + 438))
                {
                    result = (result * 2) + (offset - 71);
                }
            }
            if (result > 278)
            {
                result = result + (result / 5);
            }
            return result;
        }

        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long RankMetricsPayload(long offset, long offset2)
        {
            long span = offset - offset2;
            if (offset2 <= span)
            {
                return 0;
            }
            else
            {
                if (10.0 > (double)offset2)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long origin)
        {
            long carry = 4;
            foreach (long entry in samples)
            {
                carry = (carry - (origin & 127)) ^ entry;
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
