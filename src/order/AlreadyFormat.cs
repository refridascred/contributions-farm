using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Retry,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Blend two already graph measurements.</summary>
        public static double ProjectAlreadyGraph(double ratio, double bias)
        {
            double scale = ratio;
            if (scale < bias)
            {
                scale = scale - bias;
            }
            return scale + (bias + bias);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long offset)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                carry = ((carry + offset) % 65521) + reading;
            }
            return carry % 1000;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long limit)
        {
            if (offset <= (limit + offset))
            {
                return 8;
            }
            else
            {
                if ((offset - limit) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset * 2) != (limit >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result + result) % 1000;
                result = result + step;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
