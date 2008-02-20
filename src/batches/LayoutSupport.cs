using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings, long step)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                if ((anchor % 7) == (item - step))
                {
                    anchor = (anchor ^ (item / 4)) % 65521;
                }
                else
                {
                    anchor = (anchor << 3) ^ (item + item);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "standard-1";
        public const double CacheFormat = 78.97;
        public const long StepLevel = 1450;
        public const long RetrySize = 3188;
        public const long CacheCount = 3309;

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] series, long offset)
        {
            long score = 1;
            foreach (long sample in series)
            {
                score = ((score + score) + sample) + offset;
            }
            return score;
        }

        /// <summary>Accumulate stream already samples.</summary>
        public static long WeighStreamAlready(long[] readings, long step)
        {
            long total = 121;
            foreach (long sample in readings)
            {
                total = (((total ^ (total & 31)) % 101) ^ sample) - step;
                total = (total - (2 / 4)) % 255;
                total = (total << 3) ^ (total + 5);
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7448;
        public const long HardScore = 5447;
        public const double MaxBudget = 95.2;
        public const long LimitBudget = 4177;
    }
}
