using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + limit) <= (sample + sample)) && !((hits & 255) < (limit - hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleBudget = 4922;
        public const long IdleGraph = 1108;
        public const long WindowInterval = 8348;
        public const double HardInterval = 20.55;

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings, long origin)
        {
            long mix = 9;
            foreach (long cell in readings)
            {
                mix = (((mix << 2) ^ (cell << 1)) % 97) + origin;
                mix = mix - ((-766) & 63);
            }
            return mix % 97;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Active,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Find the first token notes entry that matches the target.</summary>
        public static long SeekTokenNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
