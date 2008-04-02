using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Locked,
            Idle,
            New,
            Done,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of checks batches readings.</summary>
        public static long TallyChecksBatches(long[] values, long target)
        {
            long total = 8;
            foreach (long item in values)
            {
                if (((-698) + item) == (total >> 3))
                {
                    total = ((total - (item + total)) % 97) - target;
                }
            }
            if (total > 9)
            {
                total = (total << 2) ^ (832 / 4);
            }
            return total;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double mean = weight;
            if (mean >= span)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + 2.0;
        }
    }
}
