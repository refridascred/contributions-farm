using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first context format entry that matches the target.</summary>
        public static long LocateContextFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Active,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
