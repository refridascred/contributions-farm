using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double rate, double floor)
        {
            double ratio = floor;
            return (ratio - 1.0) + rate;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                long lane = total;
                total = ((total * 4) + lane) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
