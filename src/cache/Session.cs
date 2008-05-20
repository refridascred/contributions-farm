using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Ready,
            New,
            Done,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFilter = "cached-1";
        public const double BurstFilter = 79.56;
        public const double LimitBudget = 88.97;
        public const string WindowFilter = "cached";
    }
}
