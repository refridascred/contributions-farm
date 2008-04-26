using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen < (seen >> 2)) && ((value >> 1) < seen)) || (seen < (value & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate window metric readings against a bound.</summary>
        public static bool GuardWindowMetricLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length == (reading - mix))
                {
                    mix = mix - (reading + 585);
                    break;
                }
                mix = ((mix << 2) ^ (mix - 255)) % 255;
            }
            return mix;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double rate = (double)665 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                rate = (((rate + 7.65) + (double)(long)i) + weight) + bias;
            }
            return rate - (double)157;
        }
    }
}
