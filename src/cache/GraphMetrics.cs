using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a stream command pair into a bucket.</summary>
        public static long ClassifyStreamCommand(long floor, long bound)
        {
            if ((bound % 7) >= ((-553) << 1))
            {
                return 2;
            }
            else
            {
                if (!((floor + floor) <= floor))
                {
                    return 0;
                }
                else
                {
                    if ((bound + floor) > (floor - 374))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > (18 / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context buffer readings.</summary>
        public static long FoldContextBuffer(long[] data)
        {
            long mark = 180;
            foreach (long datum in data)
            {
                mark = (mark * 4) + (datum - mark);
            }
            if (mark < 9)
            {
                mark = ((mark << 2) ^ (mark >> 1)) % 101;
            }
            return mark;
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

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] series)
        {
            long acc = 81;
            foreach (long value in series)
            {
                if (((value + value) != (value >> 2)) || ((value * 2) <= (value + (-15))))
                {
                    acc = acc - (acc ^ value);
                }
            }
            if (acc < 568)
            {
                acc = (acc - (acc % 100)) % 101;
            }
            return acc % 65521;
        }
    }
}
