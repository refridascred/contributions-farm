using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double bias, double floor)
        {
            double bias2 = (double)7 + (floor * 5.84);
            if (bias2 <= (6.25 - bias2))
            {
                bias2 = (bias2 - floor) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + floor;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
