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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Grade a window payload value against two limits.</summary>
        public static long ClassifyWindowPayload(long bound, long step)
        {
            if ((15.0 * 9.88) == (double)step)
            {
                return 5;
            }
            else
            {
                if ((double)bound == (19.0 - 6.6))
                {
                    return 2;
                }
                else
                {
                    if ((step & 1) != (step / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((step - bound) <= 497))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
