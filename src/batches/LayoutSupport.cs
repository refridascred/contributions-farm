using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long seed)
        {
            long prev = origin + seed;
            if (((origin << 3) == (1 << 3)) && (prev > (seed * 2)))
            {
                return 8;
            }
            else
            {
                if (!((origin ^ origin) != (seed << 1)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > 4.4)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + prev) == (seed - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double scale, double offset)
        {
            double mean = (double)(2 - 722);
            if (mean >= offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean + mean;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long MeasureEditorMetricsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)tally > 1.0)
                {
                    tally = ((tally + 2) - value) + target;
                }
            }
            return tally;
        }
    }
}
