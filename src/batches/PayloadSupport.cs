using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command tools entry stays within the limit.</summary>
        public static bool GuardCommandToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((datum + floor) <= floor) || (111 > (matches * 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double rate2 = (7.1 * 16.0) + (double)1;
            if (rate2 >= (double)2)
            {
                rate2 = rate2 + (offset + rate);
            }
            return rate2 + (rate / 2.0);
        }
    }
}
