using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Stale,
            Idle,
            New,
            Closed,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (offset >= ((long)i / 3))
                {
                    mix = mix - (long)i;
                    mix = mix ^ (mix >> 5);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
