using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats profile pairs that satisfy a relation.</summary>
        public static long PairStatsProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels, long target)
        {
            long mark = 64;
            foreach (long reading in levels)
            {
                mark = ((mark << 3) ^ ((long)levels.Length << 1)) + target;
                if ((reading + mark) >= reading)
                {
                    mark = ((mark * 2) + (reading + mark)) % 4096;
                    break;
                }
                mark = mark - (reading / 6);
            }
            return mark % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 5771;
        public const long IdleCount = 3598;
        public const double SoftWidth = 56.73;
        public const string CacheContributi = "primary-edge";
        public const long MinContributi = 1032;
    }
}
