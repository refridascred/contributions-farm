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

        /// <summary>Rank graph contributi input into a small class.</summary>
        public static long SortGraphContributi(long seed, long origin)
        {
            if (!(origin < (origin * 3)))
            {
                return 5;
            }
            else
            {
                if ((seed / 2) <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) > (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >= (seed + 362)) && ((26 * 4) <= (origin << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
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
