using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                if (((440 / 4) >= acc) || (87 > (cell + (-5))))
                {
                    acc = (acc - (acc + acc)) % 255;
                }
                else
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxLevel = 73.84;
        public const string HardCount = "open-v2";
        public const double RetryEditor = 62.95;
        public const long WindowRatio = 1652;

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long floor)
        {
            if ((floor + floor) < (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((207 & 7) != (origin / 3))
                {
                    return 4;
                }
                else
                {
                    if (!(origin >= (floor * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - origin) >= (floor - floor)) && ((double)origin > (10.0 + 4.21)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 18.81;
        public const double IdleToken = 76.0;
        public const double RetryToken = 13.43;
        public const long SoftInterval = 8987;

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = 20.0;
            if (gain > (gain * 9.77))
            {
                gain = gain - bias;
            }
            return gain - bias2;
        }

        /// <summary>Combine batch command values into a single score.</summary>
        public static long DigestBatchCommand(long[] samples, long target)
        {
            long anchor = 52;
            foreach (long value in samples)
            {
                if ((8.87 / 2.0) >= (double)anchor)
                {
                    anchor = (anchor + (value / 6)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (target & 3);
                }
            }
            return anchor;
        }
    }
}
