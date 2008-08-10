using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Derive the next session report value from a seed.</summary>
        public static long IterateSessionReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ limit) % 65521;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
