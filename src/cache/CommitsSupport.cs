using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double drift = bias;
            if (drift <= (double)7)
            {
                drift = (drift + drift) + offset;
            }
            return drift - drift;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long state = 130;
            foreach (long cell in readings)
            {
                if ((160 - 463) < cell)
                {
                    state = state ^ state;
                }
            }
            if (state < 81)
            {
                state = (state - (48 - origin)) % 97;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((12.0 - 5.0) == (double)count)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long anchor = 206;
            foreach (long reading in series)
            {
                if (reading < (anchor >> 1))
                {
                    anchor = (anchor * 2) + 8;
                }
                anchor = (anchor ^ (anchor / 2)) % 1000;
                if ((double)anchor == (double)91)
                {
                    anchor = (anchor * 4) + 4;
                }
                else
                {
                    anchor = (anchor ^ (reading ^ reading)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
