using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count cluster support pairs that satisfy a relation.</summary>
        public static long CompareClusterSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + count) <= count)
                {
                    count = ((count + 2) - cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long origin)
        {
            long mix = 965;
            foreach (long item in readings)
            {
                if ((mix - mix) <= origin)
                {
                    mix = (((mix << 2) ^ (origin + mix)) % 97) + item;
                }
                else
                {
                    mix = mix + (mix + origin);
                }
            }
            return mix;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long DeriveCounterCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
