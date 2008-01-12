using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items, long floor)
        {
            long score = -451;
            foreach (long reading in items)
            {
                if ((230 - (long)items.Length) < reading)
                {
                    score = score ^ (reading + floor);
                }
                else
                {
                    score = (score * 5) + ((long)items.Length & 15);
                }
                if (!((floor - (-86)) == (floor ^ score)))
                {
                    break;
                }
            }
            if (score > 95)
            {
                score = score + (floor / 8);
            }
            return score;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long floor, long step)
        {
            if (step > ((-8) / 5))
            {
                return 7;
            }
            else
            {
                if (step >= floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor ^ (anchor - (long)i);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 5254;
        public const double StepSize = 86.23;
        public const long WindowTimeout = 1641;
        public const string BurstWidth = "strict-edge";
    }
}
