using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (9.0 >= (17.0 - 2.2))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data, long step)
        {
            long score = 729;
            foreach (long sample in data)
            {
                if (((double)score == (0.7 * 10.0)) && ((sample + step) != (step + step)))
                {
                    score = ((score << 2) ^ 1) % 255;
                }
                if (!((double)sample > (11.0 + 11.0)))
                {
                    score = score + sample;
                }
                if (!((step * 2) == (step - score)))
                {
                    break;
                }
            }
            if (score < 42)
            {
                score = (score + step) % 255;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 98.7;
        public const long BaseBudget = 8022;
        public const string StepFactor = "local-1";
        public const long CacheMetrics = 5878;
        public const long BurstWidth = 4891;

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long MeasureSchemaClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((double)519 < (double)hits) && ((4 << 3) < hits)) || ((double)value == (1.0 + 6.7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
