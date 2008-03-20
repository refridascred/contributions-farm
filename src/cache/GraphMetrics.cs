using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool CheckClusterFormatRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = carry + (offset * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long acc = 58;
            foreach (long reading in values)
            {
                if (acc > (acc % 3))
                {
                    acc = ((acc - (567 / 2)) % 101) + reading;
                }
                else
                {
                    acc = (acc ^ (acc % 8)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((0.1 / 3.0) >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
