using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double offset)
        {
            double drift = weight;
            return (drift + (drift / 6.0)) + offset;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long sum = 458;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (759 ^ target)) % 97) ^ cell;
            }
            return sum % 4096;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long origin, long seed)
        {
            if (seed <= 60)
            {
                return 0;
            }
            else
            {
                if ((seed << 2) != (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (((seed ^ seed) < 4) && ((origin + origin) <= (origin / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3 & 15) <= (seed * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
