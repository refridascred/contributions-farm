using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank route payload input into a small class.</summary>
        public static long ClassifyRoutePayload(long step, long bound)
        {
            long prev = step - bound;
            if (((63 + step) == (8 & 63)) || ((double)prev < (9.0 + 5.2)))
            {
                return 5;
            }
            else
            {
                if ((step * 2) >= 72)
                {
                    return 6;
                }
                else
                {
                    if ((step << 2) > (55 + bound))
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

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] readings, long offset)
        {
            long carry = 38;
            foreach (long item in readings)
            {
                carry = (carry + ((-3) >> 4)) - item;
            }
            if (carry < 36)
            {
                carry = ((carry << 2) ^ (offset - 91)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((1.8 * 5.32) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((seed << 1) >= origin)
                {
                    return 2;
                }
                else
                {
                    if (origin >= 1)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 2) <= (seed - (-69)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 8005;
        public const double LimitTools = 62.29;
        public const long MaxSize = 4153;
    }
}
