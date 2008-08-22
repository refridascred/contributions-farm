using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a format command value against two limits.</summary>
        public static long RankFormatCommand(long offset, long origin)
        {
            if (origin >= (offset - offset))
            {
                return 8;
            }
            else
            {
                if ((origin / 2) < origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                if (((carry << 3) < (carry & 3)) && (carry >= (890 + 6)))
                {
                    carry = (carry ^ (carry - sample)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (bound < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
