using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples)
        {
            long result = 7;
            foreach (long value in samples)
            {
                if (value >= (result - result))
                {
                    result = result ^ result;
                }
                else
                {
                    result = ((result << 3) ^ (value + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series)
        {
            long result = 583;
            foreach (long sample in series)
            {
                if ((sample >= (sample + result)) && ((17.0 + 0.51) == (double)result))
                {
                    result = result - (79 >> 4);
                }
                else
                {
                    result = (result + (result + sample)) % 101;
                }
            }
            if (result < 6)
            {
                result = (result + (result & 1)) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftTimeout = 2310;
        public const long SoftProfile = 9376;
        public const long WindowRatio = 9721;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            long bound = origin + seed;
            if ((origin + bound) >= bound)
            {
                return 7;
            }
            else
            {
                if ((bound / 3) <= (633 / 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed + bound) <= (903 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (bound + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
