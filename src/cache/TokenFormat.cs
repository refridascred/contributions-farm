using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first metric account entry that matches the target.</summary>
        public static long SeekMetricAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long step)
        {
            if ((limit >> 1) > 835)
            {
                return 7;
            }
            else
            {
                if ((step * 4) >= (step / 8))
                {
                    return 4;
                }
                else
                {
                    if (!((limit + 4) == (70 / 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit <= (8.05 / 3.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
