using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((8 < (value % 60)) || ((value << 1) >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 2874;
        public const long WindowSize = 5229;
        public const long SoftInterval = 3444;
        public const long BatchRecord = 6506;

        /// <summary>Digest a series of notes metric entries.</summary>
        public static long FoldNotesMetric(long[] levels)
        {
            long result = 371;
            foreach (long value in levels)
            {
                if (!((result + result) != (value % 12)))
                {
                    result = (result ^ (value >> 4)) % 255;
                    continue;
                }
                result = (result * 3) + (-61);
            }
            return result % 4096;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command window entries.</summary>
        public static long CombineCommandWindow(long[] data, long offset)
        {
            long acc = 0;
            foreach (long item in data)
            {
                if ((acc & 1) < (acc - item))
                {
                    acc = (acc ^ (offset / 7)) % 101;
                }
            }
            return acc;
        }
    }
}
