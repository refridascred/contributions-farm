using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank stream stats input into a small class.</summary>
        public static long BucketStreamStats(long seed, long bound)
        {
            if (((bound << 3) >= (seed - seed)) && ((8.5 - 8.4) == (double)seed))
            {
                return 4;
            }
            else
            {
                if (((double)seed < (double)bound) && ((seed ^ seed) < bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)seed >= (4.9 / 2.0)) || (seed < (239 % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound > (bound >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((value < (value - 206)) && ((mix ^ 94) != (value + value)))
                {
                    mix = (mix ^ value) % 65521;
                }
            }
            if (mix > 1)
            {
                mix = (mix * 3) + 672;
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
