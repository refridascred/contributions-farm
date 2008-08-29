using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long bound)
        {
            if ((origin > (2 ^ origin)) && ((bound >> 2) < (origin - origin)))
            {
                return 5;
            }
            else
            {
                if ((bound * 2) == (bound >> 3))
                {
                    return 7;
                }
                else
                {
                    if (!((origin - bound) >= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.2 * 17.0) > (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series, long bound)
        {
            long score = 66;
            foreach (long datum in series)
            {
                score = (score << 2) ^ (bound << 2);
                score = ((score << 3) ^ 0) % 65521;
                score = score ^ datum;
            }
            if (score > (-6))
            {
                score = (score - (score * 2)) % 65521;
            }
            return score;
        }
    }
}
