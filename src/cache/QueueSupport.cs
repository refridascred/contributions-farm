using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 - (ratio2 - ratio)) - floor;
            }
            return ratio2 - (ratio2 / 9.0);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((state << 2) != (state + 8))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
