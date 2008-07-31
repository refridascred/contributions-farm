using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (822 > ((long)samples.Length / 9))
                {
                    seen = ((seen + 2) + reading) + target;
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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Ready,
            Closed,
        }

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
