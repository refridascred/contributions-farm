using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long origin)
        {
            long lane = offset + origin;
            if (!((double)lane >= 19.0))
            {
                return 0;
            }
            else
            {
                if (((8.22 + 6.9) < (double)origin) && (offset < (lane / 4)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)origin == (0.1 - 0.6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double offset)
        {
            double weight = offset;
            if (weight < (double)508)
            {
                weight = (weight - (double)40) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - offset) - (double)(long)i;
            }
            return weight + (weight / 7.0);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
