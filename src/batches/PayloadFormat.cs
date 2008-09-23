using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Done,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double scale, double bias)
        {
            double gain = 6.1;
            if (gain > (gain / 6.0))
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - (double)1;
            }
            return gain - scale;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((double)reading >= (5.1 / 8.0)) || ((reading + (long)levels.Length) < matches)) && ((515 + reading) != (reading ^ matches)))
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Retry,
            Done,
            Ready,
        }
    }
}
