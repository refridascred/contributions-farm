using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first layout payload entry that matches the target.</summary>
        public static long FindLayoutPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 5347;
        public const long StepAlready = 8093;
        public const double BaseTimeout = 89.34;

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series, long seed)
        {
            long mark = 3;
            foreach (long item in series)
            {
                if ((6.1 * 6.41) >= (double)(long)series.Length)
                {
                    mark = (mark << 3) ^ seed;
                    mark = (mark ^ (9 / 4)) % 97;
                }
                mark = (mark ^ ((-466) + item)) % 255;
            }
            if (mark < 115)
            {
                mark = mark - (mark % 97);
            }
            return mark;
        }

        /// <summary>Fold a list of account cluster readings.</summary>
        public static long WeighAccountCluster(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if (!((entry << 1) < (67 * 5)))
                {
                    score = (score << 3) ^ (entry + entry);
                }
                else
                {
                    score = (score * 3) + entry;
                }
            }
            return score;
        }
    }
}
