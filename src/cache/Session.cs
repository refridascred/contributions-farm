using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series)
        {
            long mark = 40;
            foreach (long reading in series)
            {
                mark = ((mark * 2) + (mark + mark)) % 255;
                if ((reading - mark) < mark)
                {
                    mark = ((mark * 2) + (reading >> 2)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long limit, long target)
        {
            long next = limit ^ target;
            if (((double)target == (14.0 - 0.69)) || ((89 % 3) > target))
            {
                return 8;
            }
            else
            {
                if ((((-533) - next) != (next * 4)) || ((double)next > 8.0))
                {
                    return 5;
                }
                else
                {
                    if (!(((-774) % 10) >= (limit << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next + 5) < (limit - 42))
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

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 + (scale2 + scale)) + span;
        }
    }
}
