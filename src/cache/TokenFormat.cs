using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a commits token reading.</summary>
        public static double ProjectCommitsToken(double gain, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 6.6) - (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long origin2)
        {
            long diff = origin - origin2;
            if (((origin2 - diff) == (origin2 + diff)) && ((9.0 - 5.97) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if ((1 >= (origin - diff)) || ((origin >> 5) <= 708))
                {
                    return 4;
                }
                else
                {
                    if (diff < (diff + diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= (448 % 64))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Ready,
            Idle,
        }
    }
}
