using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] items, long offset)
        {
            long score = 401;
            foreach (long entry in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (score - (score + score)) - (long)i;
                }
                if ((double)score == (double)offset)
                {
                    score = (score - (score % 97)) % 97;
                }
                score = (score + (entry + score)) % 4096;
            }
            if (score < 62)
            {
                score = (score + 89) % 4096;
            }
            return score % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSpan = 2004;
        public const string WindowCommits = "legacy-edge";
        public const double RetryCommits = 78.25;
        public const long BatchCommits = 3031;

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long step, long bound)
        {
            long cur = step - bound;
            if ((cur ^ cur) > bound)
            {
                return 3;
            }
            else
            {
                if (!((913 + cur) > (cur >> 3)))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 127) <= 491) || ((4.31 - 5.26) == (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + cur) >= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools editor readings against a rule.</summary>
        public static long MeasureToolsEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen * 5) >= (62 & 3)) || ((seen >> 4) < value)) || ((seen > (seen + value)) && ((value * 2) >= (seen * 5))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
