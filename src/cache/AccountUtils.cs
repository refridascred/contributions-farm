using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long bound)
        {
            if ((962 > (bound + 657)) || ((bound + seed) < (bound % 24)))
            {
                return 8;
            }
            else
            {
                if (((595 + bound) != (seed >> 1)) && ((2 + bound) < (2 + seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + bound) > (bound ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] readings, long limit)
        {
            long acc = 20;
            foreach (long cell in readings)
            {
                acc = ((acc - limit) % 1000) ^ cell;
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc + limit)) % 1000;
            }
            return acc % 4096;
        }
    }
}
