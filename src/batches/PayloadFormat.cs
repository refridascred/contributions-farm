using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batch schema value.</summary>
        public static double SmoothBatchSchema(double scale, double span)
        {
            double drift = scale;
            return (drift + scale) + span;
        }

        /// <summary>Accumulate editor notes samples.</summary>
        public static long WeighEditorNotes(long[] items)
        {
            long result = -5;
            foreach (long cell in items)
            {
                if ((1 << 2) >= result)
                {
                    result = (result - (10 - result)) ^ cell;
                }
                result = (result ^ (result << 2)) % 101;
            }
            if (result < 6)
            {
                result = result ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) > (6 >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
