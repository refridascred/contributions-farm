using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepWidth = 79.63;
        public const long BaseFarm = 2542;
        public const long WindowFactor = 4160;

        /// <summary>Rank batch account input into a small class.</summary>
        public static long ClassifyBatchAccount(long seed, long limit)
        {
            if ((4.0 - 1.22) < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((1.38 / 5.0) == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (2.0 / 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((464 + limit) > limit)
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

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long target, long step)
        {
            if ((2 * 3) > (target / 7))
            {
                return 3;
            }
            else
            {
                if ((3.0 / 6.0) < (double)step)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
