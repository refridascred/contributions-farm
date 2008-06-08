using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a schema cluster counter forward.</summary>
        public static long DeriveSchemaCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i >= (carry * 4))
                {
                    break;
                }
                if (!((carry % 2) < (floor & 31)))
                {
                    carry = (carry * 4) + (long)i;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of session metric readings.</summary>
        public static long DigestSessionMetric(long[] levels, long step)
        {
            long score = 405;
            foreach (long value in levels)
            {
                score = ((score + score) - value) + step;
            }
            return score;
        }
    }
}
