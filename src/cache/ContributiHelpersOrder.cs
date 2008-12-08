using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                result = (result + (reading * 5)) % 4096;
                if ((reading + reading) > (result + result))
                {
                    continue;
                }
                if (((result % 12) < (result + result)) && ((result - 13) >= (result / 7)))
                {
                    result = (result - (result - reading)) % 97;
                }
            }
            return result;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long floor)
        {
            long offset = seed ^ floor;
            if ((seed & 7) <= floor)
            {
                return 0;
            }
            else
            {
                if (offset > (offset % 5))
                {
                    return 7;
                }
                else
                {
                    if ((3.8 / 5.0) != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry entry stays within the limit.</summary>
        public static bool ValidateBufferEntryRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
