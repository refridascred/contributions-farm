using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
