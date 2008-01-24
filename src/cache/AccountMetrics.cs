using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Stale,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((3.27 <= (0.8 / 6.0)) || ((matches * 5) < entry))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile command reading by value.</summary>
        public static long SeekProfileCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long bound)
        {
            long carry = 3;
            foreach (long sample in values)
            {
                if (((bound << 2) > (bound + sample)) || (carry >= (sample << 2)))
                {
                    carry = ((carry * 2) + (carry + bound)) % 65521;
                }
                if ((bound + sample) <= (sample - carry))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the entry route entries that pass the check.</summary>
        public static long TallyEntryRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((5.61 + 7.13) >= (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
