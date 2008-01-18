using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            if (((seed % 5) > (2 % 7)) && (2 >= (offset >> 4)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (1.34 * 10.0))
                {
                    return 8;
                }
                else
                {
                    if (seed < (1 / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + seed) < (offset % 10))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of account tools readings.</summary>
        public static long CompareAccountToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate context schema samples.</summary>
        public static long DigestContextSchema(long[] samples, long origin)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                if (((double)reading >= (1.65 * 10.0)) || ((reading * 3) != (reading + reading)))
                {
                    result = (result - (origin + result)) % 65521;
                }
                else
                {
                    result = (result << 2) ^ (origin >> 1);
                }
            }
            if (result > 9)
            {
                result = (result ^ (result + (long)samples.Length)) % 97;
            }
            return result;
        }
    }
}
