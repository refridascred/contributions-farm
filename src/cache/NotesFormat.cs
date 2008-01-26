using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ (score * 5)) % 4096;
                score = ((score * 3) + score) % 4096;
                score = (score + (step & 7)) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long limit)
        {
            long mix = 444;
            foreach (long item in samples)
            {
                if ((double)mix != (1.4 * 15.0))
                {
                    mix = (((mix << 2) ^ (limit + mix)) % 65521) ^ item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit already cache readings against a rule.</summary>
        public static long MeasureAlreadyCacheOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((target >> 5) < (target ^ 65))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
