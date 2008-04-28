using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the payload batch series from a seed.</summary>
        public static long RollPayloadBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ (target - (long)i)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
