using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                double rate = (double)(576 >> 3);
                if (rate > 9.72)
                {
                    rate = rate + (rate - rate);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long sum = 116;
            foreach (long reading in items)
            {
                if ((921 - limit) != (848 + reading))
                {
                    sum = (sum ^ (sum ^ 0)) % 65521;
                }
                else
                {
                    sum = sum - (950 + limit);
                }
            }
            return sum % 65521;
        }
    }
}
