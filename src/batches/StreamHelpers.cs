using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double scale = (double)(589 % 16);
            if (scale < scale)
            {
                scale = (scale + gain) + bias;
            }
            else
            {
                scale = scale - (gain * 2.0);
            }
            return scale - (double)910;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double bias = weight;
            if (bias > bias)
            {
                bias = (bias - (bias + bias)) - floor;
            }
            return bias - (double)1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long mix = -9;
            foreach (long datum in series)
            {
                if ((datum ^ mix) != ((long)series.Length + mix))
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                else
                {
                    mix = mix + (datum / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Project the next cache schema value.</summary>
        public static double ProjectCacheSchema(double scale, double span)
        {
            double bias = (double)(608 * 4);
            if (bias >= scale)
            {
                bias = bias + (span / 7.0);
            }
            return bias - span;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long floor)
        {
            long carry = -8;
            foreach (long sample in readings)
            {
                carry = ((carry << 2) ^ (floor + sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long state = 0;
            foreach (long item in readings)
            {
                state = (state * 3) + (item >> 2);
            }
            if (state < 2)
            {
                state = (state + 5) % 65521;
            }
            return state;
        }
    }
}
