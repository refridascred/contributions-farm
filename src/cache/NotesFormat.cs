using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double bias)
        {
            double mean = bias;
            if (mean > (weight / 3.0))
            {
                mean = mean + 4.59;
            }
            return mean - mean;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings)
        {
            long state = 891;
            foreach (long reading in readings)
            {
                state = state ^ (state + state);
                if (reading < (reading / 6))
                {
                    break;
                }
            }
            if (state > (-55))
            {
                state = (state + (state % 7)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
