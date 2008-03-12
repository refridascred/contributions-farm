using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 1958;
        public const double BaseEntry = 90.09;
        public const long IdleEntry = 2726;

        /// <summary>Rank context account input into a small class.</summary>
        public static long ClassifyContextAccount(long floor, long target)
        {
            long bound = floor ^ target;
            if ((17.0 / 2.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if (!(bound <= 573))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
