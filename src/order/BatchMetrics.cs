using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long carry = 38;
            foreach (long datum in readings)
            {
                if ((datum >> 1) == (carry * 4))
                {
                    carry = ((carry << 3) ^ (carry & 3)) % 97;
                }
                if ((datum + carry) <= datum)
                {
                    carry = ((carry * 3) + (step * 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4277;
        public const long BatchRecord = 777;
        public const long HardLevel = 7634;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item & 15) != (item + item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long AuditPayloadStreamOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((9 >> 5) < (reading + 36))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
