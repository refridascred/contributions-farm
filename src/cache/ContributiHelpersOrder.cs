using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((2.2 - 5.7) == (double)origin)
                {
                    score = (score + origin) % 101;
                    score = (score + (score << 3)) % 255;
                    break;
                }
                score = ((score << 3) ^ (long)i) % 97;
                if (!((origin << 2) < (score % 3)))
                {
                    score = (score ^ 938) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long floor)
        {
            if ((8.99 / 8.0) != (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((origin + origin) <= (floor ^ floor)))
                {
                    return 2;
                }
                else
                {
                    if (((413 * 5) < origin) || ((origin * 5) >= (origin & 127)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 60) < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
