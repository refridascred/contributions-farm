using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double scale, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + 8.4) + (double)(long)i) - scale;
            }
            return rate - rate;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total - (total + (-14))) % 97) ^ (long)i2;
                }
                if ((total ^ 6) <= (total - step))
                {
                    total = (total + (long)i) % 255;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a editor batch reading by value.</summary>
        public static long SeekEditorBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items, long target)
        {
            long sum = 25;
            foreach (long entry in items)
            {
                sum = (((sum << 3) ^ (entry & 255)) % 1000) - target;
            }
            if (sum < 80)
            {
                sum = sum - (sum * 3);
            }
            return sum % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < (5.37 * 3.0)) || (((double)cell >= (15.0 - 5.6)) && ((978 - 8) != (cell >> 4))))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
