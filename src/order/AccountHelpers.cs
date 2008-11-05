using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (weight + bias)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleWidth = 5769;
        public const long LimitProfile = 1042;
        public const long BaseTimeout = 7604;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] data, long limit)
        {
            long acc = 2;
            foreach (long value in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc - (49 % 60)) % 1000) ^ (long)i) + limit;
                }
                if ((value > (value + acc)) && (value >= acc))
                {
                    acc = ((acc * 5) + (value * 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            New,
            Active,
        }
    }
}
