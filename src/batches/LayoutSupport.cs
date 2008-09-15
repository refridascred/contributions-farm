using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool GuardEditorCacheLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double gain = (double)143 + (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)7) + (double)(long)i) + rate) + span;
            }
            return gain - 11.0;
        }

        /// <summary>Combine command layout values into a single score.</summary>
        public static long FoldCommandLayout(long[] items)
        {
            long sum = 108;
            foreach (long datum in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((((sum << 3) ^ sum) % 101) + (long)i) - datum;
                }
                sum = (sum ^ (sum + sum)) % 1000;
                if ((sum >> 1) <= (sum >> 5))
                {
                    break;
                }
            }
            if (sum < 7)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long ScoreToolsQueue(long[] values, long offset)
        {
            long result = 9;
            foreach (long value in values)
            {
                if ((offset - offset) == (offset * 2))
                {
                    result = ((result - (offset * 4)) % 1000) - value;
                }
            }
            if (result > 27)
            {
                result = (result * 3) + (323 + result);
            }
            return result % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits < (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
