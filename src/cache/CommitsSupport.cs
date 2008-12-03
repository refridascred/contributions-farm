using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long step, long offset)
        {
            long edge = step - offset;
            if (step <= (offset - edge))
            {
                return 2;
            }
            else
            {
                if ((double)edge == (0.5 * 19.0))
                {
                    return 7;
                }
                else
                {
                    if (!((edge ^ step) < (96 + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 7508;
        public const string SoftWidth = "legacy-1";
        public const long StepFactor = 3119;
        public const long MaxWidth = 6360;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((31 / 9) < (datum + count)))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of metrics report entries.</summary>
        public static long TallyMetricsReport(long[] series)
        {
            long result = 582;
            foreach (long cell in series)
            {
                result = (result + (result + cell)) % 1000;
            }
            return result;
        }
    }
}
