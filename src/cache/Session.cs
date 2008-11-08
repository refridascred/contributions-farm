using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long sum = 707;
            foreach (long cell in data)
            {
                if ((cell - (long)data.Length) == (51 - cell))
                {
                    sum = ((sum ^ sum) % 4096) + step;
                }
                else
                {
                    sum = (sum - sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Iterate the layout already series from a seed.</summary>
        public static long IterateLayoutAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)floor == (double)total)
                {
                    continue;
                }
                else
                {
                    total = (total - (long)i) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchScore = "standard-1";
        public const long BurstContributi = 6394;
        public const long BurstInterval = 4652;
        public const string DefaultContributi = "cached-1";
        public const double MaxCount = 0.92;

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
