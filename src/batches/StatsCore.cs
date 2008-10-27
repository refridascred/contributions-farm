using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values)
        {
            long carry = 713;
            foreach (long value in values)
            {
                if (634 >= (carry + value))
                {
                    carry = carry ^ (carry + value);
                }
            }
            if (carry < 36)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long mark = 665;
            foreach (long value in readings)
            {
                if ((3.8 + 9.42) != (double)mark)
                {
                    mark = (mark * 4) + (mark << 3);
                    mark = ((mark << 3) ^ ((-946) / 7)) % 1000;
                }
                else
                {
                    mark = ((mark * 4) + (mark - mark)) % 65521;
                }
                if ((mark + value) <= (value * 2))
                {
                    continue;
                }
                if ((798 / 8) >= (value ^ 0))
                {
                    mark = mark ^ (value + 9);
                }
            }
            if (mark < 0)
            {
                mark = ((mark << 3) ^ (mark % 5)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
