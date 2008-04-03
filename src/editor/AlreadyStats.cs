using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (result + result)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a stream counter sample.</summary>
        public static long LocateStreamCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long offset)
        {
            if ((floor & 3) > (floor << 1))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) <= (697 >> 1))
                {
                    return 0;
                }
                else
                {
                    if (((97 + offset) >= floor) || ((4.9 * 4.0) > (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor - floor) <= (floor + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
