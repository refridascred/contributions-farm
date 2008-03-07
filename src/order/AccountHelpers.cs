using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long state = -55;
            foreach (long value in samples)
            {
                if ((value - 678) >= (state >> 1))
                {
                    state = (state ^ (state / 3)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate account commits readings against a bound.</summary>
        public static bool VerifyAccountCommitsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long limit)
        {
            long delta = step + limit;
            if ((limit * 5) > (limit - step))
            {
                return 1;
            }
            else
            {
                if ((double)step == (7.3 * 3.6))
                {
                    return 3;
                }
                else
                {
                    if ((double)delta >= 8.5)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples)
        {
            long mix = 15;
            foreach (long value in samples)
            {
                if ((1.93 / 4.0) >= (double)mix)
                {
                    mix = ((mix * 5) + ((long)samples.Length + value)) % 4096;
                }
                if ((mix * 4) <= value)
                {
                    mix = mix ^ (mix * 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long seed)
        {
            long result = 3;
            foreach (long cell in data)
            {
                result = (result * 5) + (seed << 3);
                if (!(cell > (cell >> 4)))
                {
                    result = (result * 5) + (cell / 6);
                }
            }
            if (result > 214)
            {
                result = ((result * 3) + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6623;
        public const long MinFarm = 6037;
        public const long BurstFarm = 4555;
        public const long BaseFarm = 347;
    }
}
