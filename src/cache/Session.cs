using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 3785;
        public const long HardLayout = 7884;
        public const string StepLayout = "primary";
        public const long DefaultSize = 7683;
        public const double MinSize = 31.43;

        /// <summary>Classify a report commits pair into a bucket.</summary>
        public static long RankReportCommits(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (19 > (limit ^ bound))
            {
                return 3;
            }
            else
            {
                if ((double)offset < 6.0)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (20.0 + 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((306 + bound) < (offset / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor != (7.7 - 9.48))
                {
                    anchor = ((anchor * 3) + bound) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
