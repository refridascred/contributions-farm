using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of format entry entries.</summary>
        public static long TallyFormatEntry(long[] levels)
        {
            long anchor = 68;
            foreach (long value in levels)
            {
                anchor = ((anchor - (anchor & 15)) % 255) + value;
            }
            if (anchor > 404)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 97;
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

        /// <summary>Audit layout graph readings against a rule.</summary>
        public static long MeasureLayoutGraphHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen > (double)datum)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Paused,
            Idle,
            Ready,
            Failed,
        }
    }
}
