using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of metrics token readings.</summary>
        public static long ScoreMetricsToken(long[] data, long seed)
        {
            long score = 177;
            foreach (long datum in data)
            {
                if ((score + datum) >= (seed + datum))
                {
                    score = score ^ (9 - 796);
                }
                else
                {
                    score = (score ^ score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every checks command entry stays within the limit.</summary>
        public static bool ValidateChecksCommandBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
