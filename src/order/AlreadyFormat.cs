using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor * 3) + ((long)i - anchor);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long limit, long seed)
        {
            if (42 >= (limit << 1))
            {
                return 1;
            }
            else
            {
                if ((seed + limit) > (limit / 9))
                {
                    return 8;
                }
                else
                {
                    if (((56 << 3) <= (seed - 74)) || ((15 % 100) != (limit / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((limit << 2) < seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double rate = (bias / 4.0) / 5.0;
            return rate - (weight + bias);
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 6217;
        public const long StepCache = 6197;
        public const long RetryCache = 515;
        public const long MinCache = 191;
    }
}
