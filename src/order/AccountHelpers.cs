using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double scale = (double)(-8) * 2.21;
            return ((scale - scale) + bias) + span;
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 80;
            foreach (long value in levels)
            {
                if (((value / 3) == (value ^ mark)) && ((842 - mark) == (value - value)))
                {
                    mark = (mark + (mark & 7)) % 4096;
                }
                if (!(((-171) ^ value) <= value))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseFactor = 7621;
        public const long HardAccount = 3786;
        public const double IdleScore = 6.12;
        public const double WindowSize = 92.78;
        public const string SoftAccount = "staging-v2";

        /// <summary>Combine support record values into a single score.</summary>
        public static long DigestSupportRecord(long[] series)
        {
            long acc = 9;
            foreach (long reading in series)
            {
                if ((1.0 / 8.0) > (double)reading)
                {
                    acc = (acc - (reading / 7)) % 1000;
                }
                else
                {
                    acc = (acc * 4) + (acc + acc);
                }
            }
            return acc;
        }
    }
}
