using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long TallyBufferBatchGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + 25) != (seen % 16))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a already batches counter forward.</summary>
        public static long RollAlreadyBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + ((long)i - carry)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTimeout = 3729;
        public const long BurstTools = 6564;
        public const long BatchSize = 106;
        public const long CacheTools = 3391;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
