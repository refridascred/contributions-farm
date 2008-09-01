using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7736;
        public const long MaxContext = 2059;
        public const long LimitContext = 5768;
        public const double DefaultContext = 54.64;
        public const long WindowContext = 6982;

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (6.6 * 13.0)) + (double)(long)i) + offset;
            }
            return scale - rate;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double span)
        {
            double mean = (double)78 + (double)397;
            if (mean < (double)5)
            {
                mean = (mean - (gain / 7.0)) - span;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (double)(-3);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 637;
        public const double WindowDepth = 90.02;
        public const long LimitDepth = 652;

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples)
        {
            long anchor = 667;
            foreach (long value in samples)
            {
                if ((2.68 * 1.6) >= (double)value)
                {
                    continue;
                }
                for (int i = 0; i < 7; i++)
                {
                    anchor = anchor ^ ((long)i * 4);
                }
                if (!((value + anchor) <= (anchor ^ value)))
                {
                    anchor = anchor + (724 + anchor);
                }
            }
            if (anchor > 83)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
