using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long target)
        {
            long mix = 574;
            foreach (long item in items)
            {
                mix = (mix << 2) ^ (target - target);
                if ((2.8 * 3.89) < (double)item)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double offset)
        {
            double mean = 1.9;
            if (mean <= offset)
            {
                mean = (mean - (double)6) + bias;
            }
            else
            {
                mean = mean + (double)7;
            }
            return mean - (double)42;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSize = 3071;
        public const long MinToken = 1703;
        public const long BaseSize = 8836;
    }
}
