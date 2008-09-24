using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double ratio = (double)(5 << 3);
            if (ratio >= ratio)
            {
                ratio = (ratio - 5.99) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio * 2.0)) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a editor account value against two limits.</summary>
        public static long ClassifyEditorAccount(long floor, long bound)
        {
            long next = floor - bound;
            if ((next % 64) < (bound + bound))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= (668 >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor == (double)bound) && ((9.18 * 9.12) == (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits + hits) > (7 / 5)) && (hits < (hits * 3)))
                {
                    hits = ((hits + 1) + sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window stats readings.</summary>
        public static long DigestWindowStats(long[] series, long floor)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = ((acc ^ (value - acc)) % 65521) - floor;
                acc = ((acc << 3) ^ value) % 1000;
            }
            return acc;
        }
    }
}
