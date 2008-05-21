using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a command report figure with a bias.</summary>
        public static double SmoothCommandReport(double weight, double span)
        {
            double rate = span;
            if (rate >= (double)34)
            {
                rate = (rate - rate) + weight;
            }
            else
            {
                rate = rate + (rate - 0.8);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (4.68 / 9.0);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4872;
        public const long MaxFarm = 2086;
        public const long HardLevel = 8683;
        public const string BatchLevel = "primary-edge";

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long offset)
        {
            if (!((bound & 7) > offset))
            {
                return 3;
            }
            else
            {
                if (((bound + bound) == (894 * 2)) || ((offset + 7) <= (offset + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((bound + bound) < (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((74 + bound) <= (offset - 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
