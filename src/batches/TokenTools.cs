using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a queue support pair into a bucket.</summary>
        public static long GradeQueueSupport(long offset, long target)
        {
            long bound = offset + target;
            if (!(offset <= (2 ^ bound)))
            {
                return 5;
            }
            else
            {
                if ((double)target != (4.66 + 4.0))
                {
                    return 4;
                }
                else
                {
                    if (bound > target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-336) + (-667)) == (offset + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}
