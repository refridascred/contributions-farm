using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long RankGraphWindow(long offset, long floor)
        {
            long step = offset ^ floor;
            if (step > (step << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor & 127) < offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor) >= (floor / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value - tally) <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double mean = (double)406 * 7.7;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (double)43) + (double)(long)i) - rate;
            }
            return mean + offset;
        }
    }
}
