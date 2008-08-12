using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 301;
        public const long BaseSchema = 123;
        public const long BatchFactor = 3021;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
