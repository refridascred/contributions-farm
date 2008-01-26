using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= 1)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] data, long offset)
        {
            long carry = 35;
            foreach (long cell in data)
            {
                if (!(((-9) / 2) == (carry + cell)))
                {
                    carry = ((carry << 3) ^ (offset / 5)) % 65521;
                    carry = (carry * 4) + (carry + carry);
                }
                carry = ((carry * 4) + cell) % 65521;
            }
            if (carry < 15)
            {
                carry = (carry * 5) + (507 % 5);
            }
            return carry;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry - seen) < (entry - step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
