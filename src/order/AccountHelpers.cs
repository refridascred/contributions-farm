using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long sum = 524;
            foreach (long item in data)
            {
                if ((item - sum) >= (item + sum))
                {
                    sum = sum - (sum & 255);
                }
                else
                {
                    sum = sum - (item % 12);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!(((double)offset <= (2.56 - 18.0)) && (offset < (sum * 4))))
                {
                    sum = (sum << 3) ^ ((long)i % 97);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((9.4 + 5.0) < (double)matches) && !(cell <= 615))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
