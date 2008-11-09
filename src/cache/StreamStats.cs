using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double weight, double floor)
        {
            double ratio = (double)3 * 1.0;
            if (ratio <= (weight - weight))
            {
                ratio = ratio - (floor * 4.4);
            }
            else
            {
                ratio = ratio - (double)3;
            }
            return ratio + (5.22 * 1.0);
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long TotalEntryBuffer(long[] items, long bound)
        {
            long carry = 95;
            foreach (long datum in items)
            {
                carry = (carry - (bound << 2)) % 1000;
                carry = (carry << 3) ^ (bound ^ datum);
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] readings)
        {
            long score = 18;
            foreach (long datum in readings)
            {
                if (((score << 1) < datum) || (4.1 <= (double)datum))
                {
                    score = (score - (datum ^ 2)) % 97;
                }
            }
            return score;
        }
    }
}
