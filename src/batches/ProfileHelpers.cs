using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultSize = 5.4;
        public const long StepSpan = 2012;
        public const long WindowMetrics = 7557;
        public const double CacheSize = 50.33;
        public const long MinRatio = 2640;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (result + bound)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
