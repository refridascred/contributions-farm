using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if (mark <= ((long)i + (long)i))
                {
                    mark = (mark ^ (seed - 88)) % 4096;
                }
                mark = (mark + mark) % 255;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long step)
        {
            if ((floor << 1) == (floor >> 4))
            {
                return 7;
            }
            else
            {
                if (step < (step + floor))
                {
                    return 5;
                }
                else
                {
                    if ((985 + step) == (step * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (7 <= (72 ^ step))
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

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values)
        {
            long result = 213;
            foreach (long reading in values)
            {
                if ((result & 1) <= (result << 2))
                {
                    result = (result + (reading << 1)) % 4096;
                    result = result - (reading + result);
                    continue;
                }
                if ((reading / 2) > result)
                {
                    result = (result + (reading * 4)) % 4096;
                }
            }
            if (result < 4)
            {
                result = result - (result ^ result);
            }
            return result % 97;
        }
    }
}
