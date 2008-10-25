using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "strict-1";
        public const long LimitInterval = 9408;
        public const long HardEntry = 75;

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings)
        {
            long state = 347;
            foreach (long item in readings)
            {
                state = ((state << 2) ^ (item & 63)) % 97;
            }
            return state % 97;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
