using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((target - hits) < (target >> 5))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinSize = "staging";
        public const double StepScore = 22.15;
        public const long HardChannel = 9223;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum / 9) >= (4 / 6)))
                {
                    sum = ((sum * 2) + sum) % 97;
                    sum = (sum + sum) % 97;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (((sum << 2) ^ (sum + 358)) % 101) + (long)i2;
                    sum = sum + sum;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate context metric readings against a bound.</summary>
        public static bool CheckContextMetricRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long target, long floor)
        {
            long step = target ^ floor;
            if ((step * 5) != (step + 158))
            {
                return 5;
            }
            else
            {
                if ((floor + step) < (28 + target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double mean = (double)(2 / 6);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + weight) + (double)(long)i) + offset;
            }
            return mean + mean;
        }
    }
}
