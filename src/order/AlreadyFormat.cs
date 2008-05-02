using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long step)
        {
            long score = 62;
            foreach (long entry in levels)
            {
                score = ((score + (896 + score)) + entry) + step;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstTimeout = 9.08;
        public const double LimitTimeout = 11.86;
        public const long DefaultQueue = 7723;
        public const long BurstQueue = 8381;

        /// <summary>Classify a layout stats pair into a bucket.</summary>
        public static long ClassifyLayoutStats(long offset, long seed)
        {
            long step = offset ^ seed;
            if ((78 / 5) > (step ^ 18))
            {
                return 6;
            }
            else
            {
                if (step > (seed - 1))
                {
                    return 2;
                }
                else
                {
                    if ((seed >> 2) == (seed % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-791) + 0) >= (step + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up channel stats samples.</summary>
        public static long MatchChannelStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
