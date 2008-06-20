using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a channel entry figure with a bias.</summary>
        public static double ScaleChannelEntry(double scale, double span)
        {
            double weight = span;
            return (weight - (double)(-594)) + scale;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            New,
            Idle,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] levels)
        {
            long acc = -211;
            foreach (long datum in levels)
            {
                if (datum > (24 & 7))
                {
                    acc = (acc - (acc + acc)) % 1000;
                }
            }
            if (acc > 57)
            {
                acc = ((acc * 2) + (78 + 7)) % 97;
            }
            return acc;
        }

        /// <summary>Find the first githubfarm stats entry that matches the target.</summary>
        public static long LocateGithubfarmStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor window series from a seed.</summary>
        public static long IterateEditorWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((limit + 1) >= limit)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = (sum - (7 & 1)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
