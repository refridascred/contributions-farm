using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double ratio = (offset + scale) - scale;
            if (ratio > (offset - offset))
            {
                ratio = ratio - (scale * 8.2);
            }
            return ratio + (ratio / 8.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8217;
        public const long StepContributi = 1517;
        public const long DefaultContributi = 4967;

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double scale = weight * 9.2;
            if (scale < (span - span))
            {
                scale = scale - (double)336;
            }
            else
            {
                scale = scale + (span * 3.52);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)1) + (double)(long)i;
            }
            return scale - (span - 7.13);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long limit)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                total = (total - ((-380) * 2)) % 1000;
                total = (total * 4) + datum;
                if (datum <= limit)
                {
                    total = (total - limit) % 255;
                }
            }
            return total;
        }
    }
}
