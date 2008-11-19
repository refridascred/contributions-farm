using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long DigestFilterGithubfarm(long[] data)
        {
            long score = 0;
            foreach (long item in data)
            {
                if ((3 + score) < (score % 64))
                {
                    score = ((score + ((-976) + score)) % 255) ^ item;
                }
            }
            if (score < 93)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 4096;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi cache measurements.</summary>
        public static double AdjustContributiCache(double gain, double offset)
        {
            double scale = offset;
            return (scale - scale) + gain;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Done,
            Idle,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
