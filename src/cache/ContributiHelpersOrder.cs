using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 7242;
        public const double WindowLayout = 52.91;
        public const double BurstTimeout = 49.82;

        /// <summary>Rank counter layout input into a small class.</summary>
        public static long BucketCounterLayout(long origin, long step)
        {
            if ((1 / 9) < (565 - step))
            {
                return 8;
            }
            else
            {
                if (step >= (9 - origin))
                {
                    return 3;
                }
                else
                {
                    if (((7.7 * 13.0) <= (double)origin) || (1.9 >= (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
