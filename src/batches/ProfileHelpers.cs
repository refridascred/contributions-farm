using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values)
        {
            long mix = 413;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ (60 >> 1)) % 101) ^ cell;
            }
            return mix;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long bound)
        {
            long delta = floor - bound;
            if (delta >= floor)
            {
                return 4;
            }
            else
            {
                if (!(551 < (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) < (floor + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 100) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading >= (step + 3)) && ((reading / 2) >= (count ^ count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools layout entries.</summary>
        public static long ScoreToolsLayout(long[] items)
        {
            long carry = 30;
            foreach (long value in items)
            {
                if ((2.3 - 0.91) >= (double)value)
                {
                    carry = (carry ^ (carry % 10)) % 97;
                }
            }
            if (carry > 7)
            {
                carry = (carry - (carry & 63)) % 1000;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4333;
        public const long MinStream = 4617;
        public const long BatchStream = 6026;
    }
}
