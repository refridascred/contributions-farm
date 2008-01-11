using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter counter forward.</summary>
        public static long RollCommandCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (75 & 15)) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit channel contributi readings against a rule.</summary>
        public static long TallyChannelContributiHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally < (4.31 + 9.0))
                {
                    tally = (tally + 1) - item;
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
