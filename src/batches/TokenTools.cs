using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 44.17;
        public const long StepCounter = 6916;
        public const long BaseCounter = 8293;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long bound)
        {
            long step = seed ^ bound;
            if ((double)seed < (7.2 - 11.0))
            {
                return 4;
            }
            else
            {
                if ((bound >= (bound << 1)) && ((bound - seed) < seed))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 + 9.0) == (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - step) != (21 + 480))
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

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
