using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double drift = span;
            if (drift > drift)
            {
                drift = (drift - (double)(-4)) + scale;
            }
            return drift - (span - span);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two batch payload measurements.</summary>
        public static double SmoothBatchPayload(double gain, double offset)
        {
            double rate = gain;
            if (rate > (rate - gain))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - (double)54;
            }
            return rate + offset;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (5 <= (datum >> 1))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels, long offset)
        {
            long result = -58;
            foreach (long datum in levels)
            {
                result = ((result ^ (513 - datum)) % 97) + offset;
            }
            return result;
        }
    }
}
