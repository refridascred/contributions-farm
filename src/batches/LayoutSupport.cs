using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - limit) != (37 % 7))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine commits format values into a single score.</summary>
        public static long TallyCommitsFormat(long[] levels, long offset)
        {
            long score = 689;
            foreach (long value in levels)
            {
                if ((9.85 - 17.0) == (double)value)
                {
                    score = (score * 5) + (offset - value);
                }
                else
                {
                    score = (score - (value * 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches > (matches - item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long origin, long seed)
        {
            if (seed >= origin)
            {
                return 4;
            }
            else
            {
                if (!(seed > 86))
                {
                    return 5;
                }
                else
                {
                    if (((-72) - origin) < seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
