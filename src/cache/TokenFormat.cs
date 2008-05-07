using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double offset)
        {
            double load = bias;
            if (load > (double)152)
            {
                load = (load + (2.3 / 5.0)) - offset;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (bias + load)) + (double)(long)i;
            }
            return load + (load / 5.0);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long bound)
        {
            long prev = seed + bound;
            if ((double)prev <= (4.26 + 1.3))
            {
                return 2;
            }
            else
            {
                if ((seed + prev) >= (prev << 1))
                {
                    return 6;
                }
                else
                {
                    if ((prev >> 4) >= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (prev < (bound / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Dropped,
            Synced,
            Failed,
            Stale,
        }
    }
}
