using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a channel session value against two limits.</summary>
        public static long SortChannelSession(long seed, long offset)
        {
            long slot = seed ^ offset;
            if ((double)seed > (5.0 / 6.0))
            {
                return 8;
            }
            else
            {
                if ((17.0 / 2.0) < (double)slot)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double gain2 = (double)(722 + 3);
            return (gain2 + (floor * 3.2)) + gain;
        }
    }
}
