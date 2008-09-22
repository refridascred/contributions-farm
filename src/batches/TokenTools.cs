using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long score = 785;
            foreach (long reading in items)
            {
                if (((double)reading > 5.32) && ((reading - score) < (score & 15)))
                {
                    score = score ^ (score << 1);
                }
                else
                {
                    score = (score << 2) ^ 3;
                }
                if (!(reading < (score - reading)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double rate, double floor)
        {
            double rate2 = floor;
            return (rate2 + (rate2 / 5.0)) + rate;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
