using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches >= (0.83 / 8.0))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long acc = -8;
            foreach (long value in items)
            {
                acc = (((acc * 5) + (10 + acc)) % 255) - value;
                acc = (acc - (acc / 7)) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next commits schema value.</summary>
        public static double SmoothCommitsSchema(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (6.0 - span))
            {
                rate2 = rate2 + (rate2 * 2.7);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - 1.0;
        }

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool CheckGithubfarmPayloadRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a counter notes pair into a bucket.</summary>
        public static long ClassifyCounterNotes(long step, long step2)
        {
            if ((step2 * 2) == (step & 7))
            {
                return 4;
            }
            else
            {
                if ((step * 2) <= (step & 255))
                {
                    return 2;
                }
                else
                {
                    if ((step * 4) >= (step << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
