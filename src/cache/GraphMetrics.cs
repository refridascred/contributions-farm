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

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSize = 9160;
        public const string LimitWidth = "fallback-v2";
        public const double MinAccount = 43.29;

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
