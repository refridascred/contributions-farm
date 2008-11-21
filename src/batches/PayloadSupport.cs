using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Compare every pair of editor stats readings.</summary>
        public static long OverlapEditorStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "legacy";
        public const string BaseScore = "stable-v2";
        public const long SoftMetric = 4504;
    }
}
