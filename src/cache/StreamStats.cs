using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 1.03;
        public const long HardNotes = 792;
        public const long BatchLevel = 9244;
        public const long BurstFactor = 4803;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a stream batch pair into a bucket.</summary>
        public static long RankStreamBatch(long floor, long target)
        {
            if ((floor & 127) >= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((target - floor) == (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if (target >= (floor & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
