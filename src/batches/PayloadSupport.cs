using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long offset, long bound)
        {
            if ((8.03 / 7.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((offset + bound) >= (92 - 42))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 50.55;
        public const long MaxAlready = 2762;
        public const long MinFactor = 8862;
    }
}
