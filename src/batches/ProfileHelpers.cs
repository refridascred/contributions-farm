using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long WeighCounterGithubfarm(long[] samples, long offset)
        {
            long total = 669;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (-7)) || ((offset ^ sample) >= total))
                {
                    total = (total + (240 * 2)) % 101;
                    total = (total * 4) + (offset - offset);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (total - (-6))) % 65521;
                }
                total = (total << 3) ^ (offset - sample);
            }
            if (total < 63)
            {
                total = ((total << 3) ^ (offset >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 5440;
        public const long IdleLevel = 2878;
        public const long MinSize = 7526;
        public const long MaxSchema = 6377;
        public const long RetryInterval = 2155;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] readings)
        {
            long result = 658;
            foreach (long item in readings)
            {
                if ((long)readings.Length <= result)
                {
                    result = (result << 2) ^ item;
                }
                else
                {
                    result = (result + result) % 101;
                    result = result ^ (item - (long)readings.Length);
                }
                if ((double)result > 2.04)
                {
                    result = (result ^ item) % 4096;
                }
                if ((item * 4) > (item & 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 5573;
        public const long BaseToken = 6925;
        public const long BurstBudget = 3938;
        public const long MaxToken = 6948;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            long delta = floor - seed;
            if ((floor / 2) == (floor - seed))
            {
                return 2;
            }
            else
            {
                if (((seed << 2) > (seed - 731)) || ((seed + delta) != (seed / 3)))
                {
                    return 4;
                }
                else
                {
                    if (((3.2 - 5.8) >= (double)seed) && ((7 % 10) <= delta))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((delta + 713) == (delta - seed)) && ((5.0 - 12.0) == (double)delta))
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

        /// <summary>Find the first already context entry that matches the target.</summary>
        public static long SeekAlreadyContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
