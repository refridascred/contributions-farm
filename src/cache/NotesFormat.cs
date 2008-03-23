using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (0.1 - bias);
        }
    }
}
