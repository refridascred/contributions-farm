using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Idle,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Count contributi context pairs that satisfy a relation.</summary>
        public static long PairContributiContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data, long target)
        {
            long total = 34;
            foreach (long reading in data)
            {
                total = ((((total << 3) ^ (total / 7)) % 97) ^ reading) - target;
            }
            return total;
        }
    }
}
