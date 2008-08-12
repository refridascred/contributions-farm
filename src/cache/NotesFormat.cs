using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double span)
        {
            double load = (weight + 9.0) / 9.0;
            if (load >= (span * 8.8))
            {
                load = load - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load - span)) + (double)(long)i;
            }
            return load - (span / 6.0);
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
