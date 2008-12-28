using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double rate = (double)181;
            if (rate > (1.9 - gain))
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - (double)0;
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long SeriesTokenContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
