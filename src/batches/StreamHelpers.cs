using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long step)
        {
            long prev = offset ^ step;
            if ((offset << 3) != (prev >> 5))
            {
                return 6;
            }
            else
            {
                if ((prev & 127) == (offset / 4))
                {
                    return 0;
                }
                else
                {
                    if (((offset - offset) < (step ^ prev)) || ((7.9 - 6.0) > (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheInterval = 74.22;
        public const double MaxFarm = 79.02;
        public const string WindowRatio = "alpha-1";
        public const double MaxInterval = 7.11;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                long hits = score << 1;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score + (hits + hits)) % 255) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 7.94;
        public const long BaseSpan = 5738;
        public const double BaseCount = 43.22;
        public const long HardScore = 4765;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ seed;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool CheckRecordFarmBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
