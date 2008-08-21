using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 9552;
        public const long MinRatio = 6893;
        public const long SoftSupport = 3452;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first order format entry that matches the target.</summary>
        public static long SeekOrderFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
