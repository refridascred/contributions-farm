using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((double)offset <= (12.0 * 1.08)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count > entry) && ((-6) <= (count - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double floor)
        {
            double load = scale;
            if (load > load)
            {
                load = load + (scale + 14.0);
            }
            else
            {
                load = load + floor;
            }
            return load + 8.99;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double ratio = scale + (scale * 8.0);
            if (ratio >= 13.0)
            {
                ratio = ratio - span;
            }
            return ratio + scale;
        }
    }
}
