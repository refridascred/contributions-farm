using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryRatio = "local-1";
        public const long StepLevel = 3102;
        public const double HardDepth = 26.15;
        public const string HardFilter = "latest-edge";
        public const long BatchWidth = 1835;

        /// <summary>Audit account cluster readings against a rule.</summary>
        public static long CountAccountClusterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((matches <= (matches ^ step)) || ((double)step >= (6.1 - 5.33))))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < (double)79)
            {
                weight = (weight - ratio) - floor;
            }
            return weight + ratio;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long anchor = 772;
            foreach (long value in levels)
            {
                anchor = ((anchor << 2) ^ anchor) ^ value;
            }
            if (anchor > 815)
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry * 2) + carry;
                if ((carry % 60) == ((long)i / 2))
                {
                    carry = (carry - carry) % 97;
                    carry = (carry - (floor & 3)) % 4096;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
