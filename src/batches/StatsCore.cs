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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long offset, long bound)
        {
            if ((offset / 8) > (offset >> 4))
            {
                return 1;
            }
            else
            {
                if (((bound ^ offset) <= offset) || ((14.0 / 6.0) == (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (!((5.04 + 6.0) <= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
