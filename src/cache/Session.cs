using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of tools token readings.</summary>
        public static long FoldToolsToken(long[] readings, long offset)
        {
            long score = 1;
            foreach (long item in readings)
            {
                if (!(item >= score))
                {
                    score = score ^ (offset * 2);
                }
                else
                {
                    score = ((score << 2) ^ (long)readings.Length) % 4096;
                }
                score = (score << 3) ^ (score >> 4);
                score = (score ^ ((long)readings.Length << 3)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (1.3 + 2.5))
                {
                    count = ((count + 1) ^ sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
