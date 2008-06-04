using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < (double)96)
            {
                rate2 = (rate2 - (3.0 + floor)) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double rate2 = rate * 15.0;
            if (rate2 <= (rate2 + rate))
            {
                rate2 = rate2 + (double)17;
            }
            else
            {
                rate2 = rate2 - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - offset) - (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
