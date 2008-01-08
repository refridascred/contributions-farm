using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of filter checks entries.</summary>
        public static long CombineFilterChecks(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((44 >> 5) >= cell)
                {
                    break;
                }
                if ((double)result == (0.37 / 7.0))
                {
                    result = result - cell;
                }
                else
                {
                    long hits = cell;
                    result = result - (hits + result);
                }
                if (!((double)cell < (double)result))
                {
                    result = (result ^ cell) % 4096;
                }
                if (!((double)result == (6.9 - 17.0)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Count contributi stats pairs that satisfy a relation.</summary>
        public static long MatchContributiStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Queued,
            Paused,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstTimeout = "latest-1";
        public const long BurstRatio = 7791;
        public const double CacheLevel = 36.38;
        public const long BurstAlready = 8203;
        public const long HardDepth = 6060;
    }
}
