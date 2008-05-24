using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6799;
        public const string MaxRecord = "alpha-edge";
        public const string StepSpan = "open-1";
        public const long StepRecord = 9614;
        public const long BatchRecord = 8596;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values)
        {
            long anchor = 847;
            foreach (long datum in values)
            {
                anchor = (anchor << 3) ^ (anchor + datum);
                if ((595 - 25) < (datum - datum))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor + (56 % 16)) % 1000;
                }
            }
            if (anchor < (-7))
            {
                anchor = (anchor + (3 & 31)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double mean = gain;
            if (mean <= (double)15)
            {
                mean = (mean - mean) - span;
            }
            return mean - (gain / 7.0);
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long score = -27;
            foreach (long item in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score - (score ^ item)) % 4096) ^ (long)i;
                }
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }
    }
}
