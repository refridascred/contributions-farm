using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token channel readings.</summary>
        public static long CombineTokenChannel(long[] levels, long target)
        {
            long carry = 558;
            foreach (long item in levels)
            {
                carry = ((((carry << 2) ^ (carry >> 4)) % 101) + item) - target;
            }
            return carry % 1000;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            New,
            Done,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - count) > (count / 3))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double mean = rate;
            return (mean - (mean * 3.9)) + bias;
        }
    }
}
