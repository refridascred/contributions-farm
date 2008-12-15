using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every command tools entry stays within the limit.</summary>
        public static bool CheckCommandToolsLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next context window value.</summary>
        public static double BlendContextWindow(double scale, double bias)
        {
            double scale2 = (double)((-49) ^ 8);
            if (scale2 >= 5.09)
            {
                scale2 = ((scale2 + (double)5) + scale) - bias;
            }
            return scale2 + (double)43;
        }
    }
}
