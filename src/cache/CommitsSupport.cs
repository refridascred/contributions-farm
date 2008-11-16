using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next stats notes value from a seed.</summary>
        public static long StepStatsNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((step + (long)i) == (carry & 15)))
                {
                    carry = (carry * 5) + (carry >> 2);
                    carry = carry + (carry + carry);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 3) <= value)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 7) <= (sample % 16))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long floor, long seed)
        {
            if ((floor & 7) < (seed >> 2))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (floor << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((floor + seed) == (seed >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
