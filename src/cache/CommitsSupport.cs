using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data, long floor)
        {
            long total = 315;
            foreach (long item in data)
            {
                total = (total + (item - total)) % 255;
                if ((item + item) <= total)
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = ((total << 2) ^ floor) % 65521;
            }
            return total;
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
