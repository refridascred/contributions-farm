using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)count >= (11.0 * 7.6)) && !((85 ^ datum) > (datum >> 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] values)
        {
            long carry = 55;
            foreach (long datum in values)
            {
                carry = (((carry * 2) + (carry + carry)) % 65521) + datum;
            }
            return carry % 4096;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Stale,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double bias = (double)(-619) * 4.7;
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + bias) + (double)(long)i) + scale) + span;
            }
            return bias + (double)(-8);
        }
    }
}
