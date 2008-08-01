using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long limit)
        {
            if (((origin % 7) >= (origin & 31)) && (limit >= (limit & 1)))
            {
                return 3;
            }
            else
            {
                if (limit <= (limit & 127))
                {
                    return 1;
                }
                else
                {
                    if (limit < (limit + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit <= (origin - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double load = (double)36 - weight;
            if (load > (double)547)
            {
                load = load - (load + 8.79);
            }
            else
            {
                load = load + load;
            }
            return load + (offset / 9.0);
        }
    }
}
