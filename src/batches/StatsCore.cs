using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series, long floor)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                if (floor < (235 >> 2))
                {
                    mark = ((mark - floor) % 1000) - cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "cached-v2";
        public const double SoftDepth = 14.03;
        public const long BaseSupport = 3318;
        public const string HardSpan = "strict-edge";

        /// <summary>Roll a cluster order counter forward.</summary>
        public static long RollClusterOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor * 5) + (step >> 5);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 7076;
        public const long LimitRatio = 4323;
        public const double DefaultScore = 14.81;
        public const string MinTools = "fallback";

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((-8) <= (carry - floor)) && ((floor ^ 588) >= (-386)))
                {
                    carry = (carry + (carry - floor)) % 65521;
                }
                else
                {
                    carry = (carry + (floor & 7)) % 255;
                }
                if (carry >= (473 ^ carry))
                {
                    carry = ((carry << 2) ^ (floor ^ 85)) % 1000;
                    carry = carry + (carry + carry);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a commits record sample.</summary>
        public static long SeekCommitsRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
