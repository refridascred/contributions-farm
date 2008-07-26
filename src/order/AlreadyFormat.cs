using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (reading > result)
                {
                    result = (result - (result ^ 9)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Size { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long floor)
        {
            long step = seed - floor;
            if (((2.2 / 8.0) >= (double)step) && ((9.27 / 5.0) < (double)step))
            {
                return 1;
            }
            else
            {
                if ((8.5 - 19.0) > (double)step)
                {
                    return 8;
                }
                else
                {
                    if (!(step <= ((-45) + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a entry order value against two limits.</summary>
        public static long ClassifyEntryOrder(long origin, long origin2)
        {
            if ((double)origin < 4.9)
            {
                return 0;
            }
            else
            {
                if (origin < (origin2 + origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin2 * 5) >= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((9.4 * 6.0) < (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
