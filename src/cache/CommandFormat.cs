using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9875;
        public const long BurstFactor = 2453;
        public const long MinWidth = 4650;
        public const string HardCounter = "staging-v2";
        public const long BaseBudget = 1736;

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings, long seed)
        {
            long acc = -746;
            foreach (long cell in readings)
            {
                acc = (acc << 2) ^ (seed / 5);
                if (592 >= cell)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long target)
        {
            long edge = step - target;
            if ((target + 0) > 245)
            {
                return 4;
            }
            else
            {
                if ((edge + target) < edge)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
