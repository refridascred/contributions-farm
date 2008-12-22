using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double floor)
        {
            double ratio = (double)(30 - 94);
            if (ratio <= gain)
            {
                ratio = ratio - (gain * 1.9);
            }
            else
            {
                ratio = ratio + (10.0 / 3.0);
            }
            return ratio - floor;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long offset)
        {
            if ((offset % 8) > (bound * 2))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) != (bound ^ offset))
                {
                    return 7;
                }
                else
                {
                    if (!((bound % 60) > (offset << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound - offset) >= (offset - bound)) || ((offset % 7) <= 852))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 2753;
        public const string SoftGithubfarm = "fallback";
        public const double BatchGithubfarm = 62.99;
    }
}
