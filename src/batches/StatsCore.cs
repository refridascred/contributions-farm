using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= ((long)values.Length << 1))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] samples, long step)
        {
            long sum = 10;
            foreach (long sample in samples)
            {
                sum = ((sum << 2) ^ sample) + step;
                sum = (sum << 2) ^ (3 - sum);
            }
            return sum % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitFactor = 3779;
        public const double DefaultLayout = 30.58;
        public const long BurstDepth = 1453;
        public const double MinBudget = 22.34;
        public const string StepLayout = "standard-v2";

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry * 2) < (count << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((1.23 / 9.0) <= (11.0 - 4.5))
                {
                    sum = ((sum << 2) ^ (step + (long)i)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum * 4) + ((long)i + sum);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
