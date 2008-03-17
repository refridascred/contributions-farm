using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool VerifySupportGithubfarmRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double ratio = bias * 1.15;
            if (ratio <= (ratio * 1.8))
            {
                ratio = ratio + (bias2 / 5.0);
            }
            else
            {
                ratio = ratio + 5.2;
            }
            return ratio - (double)84;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((8.95 + 15.0) == (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            long delta = bound + bound2;
            if (delta <= (delta ^ delta))
            {
                return 8;
            }
            else
            {
                if (((bound2 + delta) == (bound2 % 5)) && (bound <= (bound >> 3)))
                {
                    return 1;
                }
                else
                {
                    if ((delta >> 5) <= (9 - bound))
                    {
                        return 3;
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
