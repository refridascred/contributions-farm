using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count % 16) == (datum % 16)) || ((double)count > (4.52 - 6.57)))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double gain = 3.6;
            if (gain > bias)
            {
                gain = (gain - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)59;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if (datum >= score)
                {
                    score = ((score << 3) ^ datum) % 65521;
                    break;
                }
                else
                {
                    score = (score ^ ((long)readings.Length ^ score)) % 1000;
                }
                score = score - (datum + datum);
            }
            return score;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Active,
            Done,
            New,
            Draft,
        }
    }
}
