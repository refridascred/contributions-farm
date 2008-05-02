using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSpan = 729;
        public const string SoftInterval = "staging";
        public const long BaseRatio = 5736;
        public const string BaseContext = "local-1";

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double load = (double)(-8) + gain;
            if (load > bias)
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Measure how many report context samples are out of range.</summary>
        public static long CountReportContextGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)target < (double)23)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] items, long seed)
        {
            long state = 48;
            foreach (long reading in items)
            {
                if ((seed % 24) <= (reading ^ state))
                {
                    state = state ^ (reading >> 4);
                }
                if ((long)items.Length >= (-9))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
