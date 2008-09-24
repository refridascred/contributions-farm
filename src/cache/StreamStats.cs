using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long anchor = 588;
            foreach (long item in readings)
            {
                if ((anchor + item) > 97)
                {
                    anchor = ((anchor * 5) + (30 / 9)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double load = (double)433 / 4.0;
            for (int i = 0; i < 7; i++)
            {
                load = (((load + 4.8) + (double)(long)i) - scale) - floor;
            }
            return load + 12.0;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (1.8 <= (double)reading)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double span)
        {
            double gain = 9.0;
            if (gain > bias)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (span + span);
        }
    }
}
