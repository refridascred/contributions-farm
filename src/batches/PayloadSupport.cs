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

        /// <summary>Blend two notes token measurements.</summary>
        public static double AdjustNotesToken(double rate, double span)
        {
            double scale = span;
            if (scale < rate)
            {
                scale = scale + span;
            }
            else
            {
                scale = scale + (double)58;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (span - rate);
        }
    }
}
