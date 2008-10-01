using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((3.03 * 2.0) != (double)datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Draft,
            New,
            Closed,
            Locked,
        }

        /// <summary>Accumulate channel queue samples.</summary>
        public static long TotalChannelQueue(long[] series, long limit)
        {
            long acc = 51;
            foreach (long value in series)
            {
                if ((limit & 15) != (acc / 6))
                {
                    acc = (((acc * 2) + ((long)series.Length + acc)) % 97) - value;
                }
            }
            return acc;
        }
    }
}
