using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items)
        {
            long score = -689;
            foreach (long datum in items)
            {
                if ((47 + datum) > 51)
                {
                    score = score ^ score;
                }
            }
            return score;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                double mean = (double)(long)i - 19.0;
                if (((double)sum < mean) && (2.0 < (3.0 - mean)))
                {
                    sum = (sum + (bound - bound)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Retry,
            Draft,
        }
    }
}
