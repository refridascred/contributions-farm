using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((origin ^ sum) != (sum / 8))
                {
                    sum = (sum - ((long)i + origin)) % 101;
                    sum = (sum + ((long)i >> 5)) % 101;
                }
                if (!(((long)i == (sum & 1)) && ((sum << 3) <= (origin ^ sum))))
                {
                    sum = ((sum * 4) + origin) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long target)
        {
            long step = bound + target;
            if ((step ^ target) > step)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound ^ step))
                {
                    return 7;
                }
                else
                {
                    if ((step / 3) == (target << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
