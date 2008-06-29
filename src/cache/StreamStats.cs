using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series, long seed)
        {
            long sum = 67;
            foreach (long datum in series)
            {
                if (!((double)sum != (9.0 + 5.5)))
                {
                    sum = ((sum << 2) ^ sum) % 4096;
                }
                sum = (sum * 2) + (datum + datum);
            }
            if (sum > 196)
            {
                sum = sum + (seed - 195);
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double scale = (double)(0 / 2);
            if (scale >= (span * 6.0))
            {
                scale = scale - (double)125;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (double)84;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((origin / 9) == (origin >> 3)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
