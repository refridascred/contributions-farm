using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "standard-edge";
        public const string IdleGraph = "legacy-edge";
        public const long MinGraph = 8000;
        public const long BaseInterval = 3059;

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
