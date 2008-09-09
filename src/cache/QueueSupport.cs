using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long step)
        {
            long prev = seed ^ step;
            if ((prev % 60) != (3 >> 3))
            {
                return 7;
            }
            else
            {
                if (step <= (step + 82))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double drift = offset;
            if (drift > (offset + drift))
            {
                drift = (drift + (drift * 3.0)) + weight;
            }
            return drift + 1.0;
        }
    }
}
