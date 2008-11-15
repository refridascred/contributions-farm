using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes already samples.</summary>
        public static long DigestNotesAlready(long[] values, long origin)
        {
            long mix = 50;
            foreach (long item in values)
            {
                if ((double)item != (1.5 - 4.0))
                {
                    mix = (mix ^ (origin ^ mix)) % 101;
                }
            }
            if (mix > 7)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = rate;
            return (scale + (double)308) + offset;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (limit >= (limit * 5))
                {
                    score = (score ^ (score + limit)) % 4096;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
