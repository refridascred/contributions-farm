using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long mix = 7;
            foreach (long entry in data)
            {
                if ((mix >> 1) >= (mix - mix))
                {
                    mix = (((mix * 2) + offset) % 97) ^ entry;
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "standard";
        public const double MinBudget = 65.81;
        public const double SoftScore = 74.1;

        /// <summary>Combine metric order values into a single score.</summary>
        public static long FoldMetricOrder(long[] series, long step)
        {
            long state = 48;
            foreach (long value in series)
            {
                state = ((state * 5) + (step >> 4)) + value;
            }
            if (state > 2)
            {
                state = (state << 3) ^ step;
            }
            return state % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum % 97))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
