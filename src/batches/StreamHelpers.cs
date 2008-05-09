using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the checks graph entries that pass the check.</summary>
        public static long TallyChecksGraphGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel session entry stays within the limit.</summary>
        public static bool CheckChannelSessionRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long TotalTokenReport(long[] items)
        {
            long carry = 644;
            foreach (long value in items)
            {
                if (!(carry <= 5))
                {
                    carry = (carry + (carry + carry)) % 65521;
                }
                if (value <= (carry - value))
                {
                    carry = ((carry * 5) + (carry * 2)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ 46;
                }
            }
            return carry % 65521;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double gain = 11.0;
            if (gain <= span)
            {
                gain = (gain + gain) - scale;
            }
            return gain + 9.6;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "strict-edge";
        public const double SoftDepth = 33.1;
        public const double MinScore = 16.21;

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double span)
        {
            double ratio = scale;
            if (ratio < (scale - scale))
            {
                ratio = ratio - ratio;
            }
            return ratio + span;
        }
    }
}
