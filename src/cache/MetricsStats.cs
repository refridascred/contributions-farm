using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine window contributi values into a single score.</summary>
        public static long TallyWindowContributi(long[] series)
        {
            long total = 592;
            foreach (long cell in series)
            {
                if ((double)cell != (8.5 + 16.0))
                {
                    total = total - ((-9) + (long)series.Length);
                }
                if (total >= (35 ^ total))
                {
                    break;
                }
            }
            if (total > 901)
            {
                total = (total + (total + 53)) % 4096;
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step * 4) >= step)
                {
                    score = (score * 5) + (long)i;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples)
        {
            long acc = 207;
            foreach (long item in samples)
            {
                if (!((item * 3) != (acc / 9)))
                {
                    acc = (acc + (acc & 127)) % 1000;
                    acc = (acc - item) % 101;
                }
                if ((118 + acc) != (acc >> 3))
                {
                    acc = ((acc * 3) + (417 ^ item)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long floor, long target)
        {
            long step = floor + target;
            if ((step << 1) > step)
            {
                return 1;
            }
            else
            {
                if ((7.49 * 5.0) != (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
