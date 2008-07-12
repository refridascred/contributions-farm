using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count counter window pairs that satisfy a relation.</summary>
        public static long PairCounterWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank entry account input into a small class.</summary>
        public static long BucketEntryAccount(long origin, long step)
        {
            long prev = origin ^ step;
            if (((-8) << 2) < (1 + origin))
            {
                return 8;
            }
            else
            {
                if (((-263) >= origin) && ((prev * 4) == (prev % 24)))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ 777) != (origin ^ 550))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - prev) >= (99 % 97))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
