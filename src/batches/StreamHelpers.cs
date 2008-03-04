using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a stats payload sample.</summary>
        public static long LookupStatsPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowLevel = 2469;
        public const long MinToken = 3328;
        public const long CacheScore = 6786;

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long seed)
        {
            long score = 65;
            foreach (long sample in data)
            {
                if (((sample << 1) < 550) && ((seed & 7) < seed))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = ((score * 2) + (83 % 16)) % 255;
                }
            }
            return score;
        }

        /// <summary>Measure how many session buffer samples are out of range.</summary>
        public static long TallySessionBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((474 << 3) == (cell & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long bound)
        {
            long result = 288;
            foreach (long entry in readings)
            {
                result = ((result - (result + result)) % 101) ^ entry;
            }
            if (result < 59)
            {
                result = (result + bound) % 97;
            }
            return result;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
