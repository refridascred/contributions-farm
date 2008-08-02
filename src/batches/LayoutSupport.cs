using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 8.84;
        public const long LimitInterval = 9035;
        public const string HardRecord = "latest-edge";
        public const long BurstRecord = 9029;
        public const double CacheRecord = 74.43;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            if ((bound ^ bound) > (offset - bound))
            {
                return 7;
            }
            else
            {
                if ((offset * 3) > (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of layout channel readings.</summary>
        public static long TotalLayoutChannel(long[] samples, long step)
        {
            long result = 0;
            foreach (long sample in samples)
            {
                result = (result - (step - sample)) % 4096;
                if (((step + result) >= (step / 4)) && (step <= sample))
                {
                    result = (result ^ (step % 100)) % 255;
                }
            }
            if (result > 878)
            {
                result = (result + ((-371) + 158)) % 101;
            }
            return result % 4096;
        }
    }
}
