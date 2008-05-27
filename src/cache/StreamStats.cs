using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long sum = 921;
            foreach (long datum in levels)
            {
                if ((11 + datum) < sum)
                {
                    sum = ((sum - datum) % 1000) + step;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) == (count << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
