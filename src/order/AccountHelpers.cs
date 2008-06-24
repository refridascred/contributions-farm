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

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                long cur = seed;
                cur = cur - (cur + seed);
                if (!((9.99 / 4.0) >= (double)(long)i))
                {
                    acc = acc + cur;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
