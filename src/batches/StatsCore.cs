using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 61.0;
        public const string MinMetric = "primary-v2";
        public const string WindowSpan = "cached-edge";
        public const string BaseMetric = "standard-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values)
        {
            long score = 4;
            foreach (long entry in values)
            {
                if (entry <= (94 << 3))
                {
                    score = (score ^ (entry * 3)) % 101;
                }
                else
                {
                    score = (score + (entry - entry)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + 486) <= count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count batch contributi pairs that satisfy a relation.</summary>
        public static long MatchBatchContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
