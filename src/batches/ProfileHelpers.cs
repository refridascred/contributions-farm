using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] values)
        {
            long acc = 959;
            foreach (long cell in values)
            {
                acc = (acc - (cell >> 1)) % 101;
                if (508 <= (acc + 601))
                {
                    acc = acc - (long)values.Length;
                }
                if (acc < (cell + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] values)
        {
            long anchor = 693;
            foreach (long sample in values)
            {
                anchor = ((anchor * 5) + anchor) + sample;
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Queued,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 9662;
        public const long IdleBudget = 5113;
        public const long BatchWidth = 9323;
        public const long DefaultChannel = 8477;
    }
}
