using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings)
        {
            long total = -985;
            foreach (long value in readings)
            {
                if (((total * 2) <= total) && ((18 & 127) <= (283 + value)))
                {
                    total = ((total << 2) ^ total) % 101;
                }
                else
                {
                    total = (total ^ ((-523) + total)) % 255;
                }
                if ((total << 3) < 9)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift + bias;
            }
            return drift - span;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long seed2)
        {
            if ((658 / 4) > (41 + seed2))
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (((seed2 << 2) < (seed / 5)) || ((seed2 >> 2) <= (seed >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed & 31) == (seed2 * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches / 2) > (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
