using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 4547;
        public const string StepRatio = "legacy-v2";
        public const string HardWidth = "local-1";

        /// <summary>Match up metric editor samples.</summary>
        public static long PairMetricEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
