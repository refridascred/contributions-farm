using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long step)
        {
            if (9.6 > (double)step)
            {
                return 6;
            }
            else
            {
                if (offset < (step + 15))
                {
                    return 5;
                }
                else
                {
                    if ((6.95 + 14.0) != (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the order contributi series from a seed.</summary>
        public static long StepOrderContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((13.0 - 6.79) == (double)offset)
                {
                    score = score - (score - offset);
                    score = (score << 2) ^ score;
                }
                score = ((score * 5) + (96 / 3)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long step)
        {
            long score = -447;
            foreach (long reading in readings)
            {
                if (((score ^ score) != (reading << 2)) && ((17.0 - 7.5) <= (4.0 + 0.84)))
                {
                    score = score + (score + step);
                }
                else
                {
                    score = (score ^ reading) % 65521;
                }
            }
            return score;
        }
    }
}
