using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardDepth = 1.8;
        public const long LimitStream = 6703;
        public const long MaxBudget = 4917;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (729 % 2)) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series)
        {
            long acc = 315;
            foreach (long datum in series)
            {
                if (datum > (acc + datum))
                {
                    acc = (acc * 5) + (66 * 5);
                }
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc + 443) % 65521) + (long)i;
                }
                if (datum >= 742)
                {
                    acc = ((acc * 5) + (acc + datum)) % 101;
                }
            }
            if (acc > 7)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc % 65521;
        }
    }
}
