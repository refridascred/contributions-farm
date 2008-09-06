using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of token commits readings.</summary>
        public static long TallyTokenCommits(long[] values, long step)
        {
            long mix = 0;
            foreach (long cell in values)
            {
                if ((26 - mix) > (step + mix))
                {
                    mix = (mix ^ (mix + mix)) + cell;
                }
                else
                {
                    mix = (mix - (step << 3)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Locate a profile stats reading by value.</summary>
        public static long SeekProfileStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!!((3 & 7) >= sample))
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
