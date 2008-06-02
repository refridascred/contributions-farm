using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Roll a session window counter forward.</summary>
        public static long IterateSessionWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the account stats entries that pass the check.</summary>
        public static long MeasureAccountStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((1.95 + 7.06) > (double)tally)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                long tally = (long)i >> 2;
                if ((score + tally) >= 480)
                {
                    score = ((score * 5) + (long)i) % 97;
                    score = (score ^ (step ^ tally)) % 255;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - floor) > ((long)i + (long)i))
                {
                    acc = (acc + ((long)i / 9)) % 4096;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
