using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - matches) < (sample / 6))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = (scale - (5.9 + 6.2)) - offset;
            }
            return scale + scale;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long bound, long target)
        {
            if ((target << 3) > bound)
            {
                return 2;
            }
            else
            {
                if ((6.7 - 4.1) != (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((25 + 6) < target)
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "standard-edge";
        public const string CacheDepth = "primary";
        public const long HardDepth = 8587;
        public const double StepTimeout = 4.08;
    }
}
