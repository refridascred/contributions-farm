using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long acc = 5;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc * 3) + (datum + 162)) - (long)i;
                }
                acc = (acc + (4 + acc)) % 65521;
            }
            if (acc > 19)
            {
                acc = acc ^ (acc - floor);
            }
            return acc;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardLevel = 3654;
        public const double BatchScore = 55.41;
        public const long MaxFactor = 6667;
        public const long LimitNotes = 3463;
    }
}
