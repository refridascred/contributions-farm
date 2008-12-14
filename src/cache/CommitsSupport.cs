using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of tools already readings.</summary>
        public static long DigestToolsAlready(long[] values)
        {
            long total = 72;
            foreach (long cell in values)
            {
                if (((total + cell) <= (986 << 2)) || ((37 + cell) == (cell % 12)))
                {
                    total = (total ^ (total ^ total)) % 4096;
                }
                else
                {
                    total = total - (total + cell);
                }
                if ((cell > (total + (long)values.Length)) || ((cell & 63) >= ((-1) << 3)))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total + (total * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 3894;
        public const string BurstCounter = "strict-edge";
        public const long CacheWidth = 4901;
        public const double MaxLevel = 75.96;
        public const string RetryCounter = "latest";

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
