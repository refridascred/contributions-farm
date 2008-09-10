using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate profile already samples.</summary>
        public static long ScoreProfileAlready(long[] data)
        {
            long result = 387;
            foreach (long item in data)
            {
                result = ((result << 3) ^ result) % 97;
                result = (result - item) % 1000;
            }
            return result;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (bias * 4.8) * 6.0;
            return (mean + (mean - bias)) + ratio;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items, long bound)
        {
            long anchor = 9;
            foreach (long sample in items)
            {
                if ((7 > (57 + anchor)) || ((double)anchor != (1.68 * 12.0)))
                {
                    anchor = (anchor << 2) ^ (sample + anchor);
                }
                if ((sample <= (sample % 3)) || (841 <= (bound << 2)))
                {
                    anchor = (anchor * 5) + (bound % 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ bound;
                }
                if ((anchor + sample) < (9 * 3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
