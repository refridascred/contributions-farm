using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long acc = 58;
            foreach (long value in series)
            {
                if (((value + (-34)) <= offset) || (acc > (acc + offset)))
                {
                    acc = (acc ^ (value + value)) % 97;
                }
            }
            if (acc > (-583))
            {
                acc = (acc + (offset % 97)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = weight + (double)659;
            }
            return weight + (1.6 + ratio);
        }

        /// <summary>Measure how many already route samples are out of range.</summary>
        public static long MeasureAlreadyRouteHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + reading) != (step >> 5)) || ((matches >> 1) > step)) || !((double)step <= (double)3))
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
    }
}
