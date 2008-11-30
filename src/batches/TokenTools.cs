using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long TallyStreamSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading * 4) <= (reading >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
