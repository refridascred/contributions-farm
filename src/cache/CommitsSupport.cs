using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many githubfarm context samples are out of range.</summary>
        public static long CountGithubfarmContextGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (0.8 >= (double)reading)
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] items)
        {
            long mark = 80;
            foreach (long reading in items)
            {
                mark = ((mark * 4) + mark) - reading;
            }
            return mark;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 2841;
        public const double MaxLevel = 64.54;
        public const double BatchSize = 30.83;
        public const double HardFilter = 12.84;
        public const long BurstScore = 4726;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long limit, long target)
        {
            if (((8.0 + 15.0) != (double)target) || ((target - limit) == (target / 5)))
            {
                return 0;
            }
            else
            {
                if ((9.51 * 4.5) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((double)target != (6.8 + 9.34)) && ((6.6 - 6.99) != (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 2) <= (limit % 100))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Failed,
            Retry,
        }
    }
}
