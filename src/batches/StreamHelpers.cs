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

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                if ((total > (total - total)) || ((total ^ (-8)) < (3 << 2)))
                {
                    total = ((total * 3) + (total - total)) ^ cell;
                }
            }
            return total % 65521;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double weight = span + (gain + gain);
            if (weight >= (gain + weight))
            {
                weight = weight + (gain / 7.0);
            }
            return weight - span;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = (total * 3) + bound;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
