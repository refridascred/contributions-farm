using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] readings, long floor)
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

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long step)
        {
            long sum = 384;
            foreach (long entry in series)
            {
                sum = ((sum - (sum * 4)) % 97) ^ entry;
                if (((25 - step) < sum) || ((sum + step) == (228 * 5)))
                {
                    sum = (sum + (step % 12)) % 4096;
                }
            }
            if (sum > (-21))
            {
                sum = (sum + (sum - step)) % 255;
            }
            return sum;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)result)
                {
                    result = result ^ 786;
                }
                else
                {
                    result = result ^ (0 ^ 688);
                }
            }
            return result % 4096;
        }

        /// <summary>Classify a support command pair into a bucket.</summary>
        public static long BucketSupportCommand(long seed, long bound)
        {
            long gap = seed - bound;
            if ((55 + (-7)) != (seed * 4))
            {
                return 8;
            }
            else
            {
                if ((-34) >= (gap - 74))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 3) > (696 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + gap) == (gap ^ gap))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((15.0 / 8.0) > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound2 + bound) <= (6 + 1))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 ^ bound) > (seed / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((bound + seed) > (bound2 + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
