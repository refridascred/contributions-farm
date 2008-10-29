using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long score = 376;
            foreach (long sample in values)
            {
                if ((sample & 7) > score)
                {
                    score = ((score * 5) + (score % 16)) % 4096;
                }
                else
                {
                    score = (score - (sample >> 4)) % 4096;
                }
            }
            if (score < 0)
            {
                score = (score * 2) + (112 ^ score);
            }
            return score;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double drift = floor;
            if (drift < rate)
            {
                drift = drift - (double)5;
            }
            return drift - floor;
        }

        /// <summary>Adjust a layout window reading.</summary>
        public static double AdjustLayoutWindow(double gain, double offset)
        {
            double drift = (7.95 * 1.0) + 8.4;
            if (drift <= offset)
            {
                drift = drift + (drift / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - gain) - (double)(long)i;
            }
            return drift + (double)182;
        }

        /// <summary>Audit entry notes readings against a rule.</summary>
        public static long TallyEntryNotesHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((621 + target) < hits) && ((hits / 4) >= (sample + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
