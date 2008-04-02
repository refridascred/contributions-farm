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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long target)
        {
            if ((seed >> 3) == (seed >> 1))
            {
                return 5;
            }
            else
            {
                if ((target + 533) >= (seed - 724))
                {
                    return 8;
                }
                else
                {
                    if ((seed + target) > (seed >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
