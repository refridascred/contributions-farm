using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Blend two contributi batch measurements.</summary>
        public static double ProjectContributiBatch(double weight, double offset)
        {
            double mean = 8.0;
            if (mean < offset)
            {
                mean = mean + (double)(-447);
            }
            else
            {
                mean = mean - (mean - weight);
            }
            return mean + weight;
        }
    }
}
