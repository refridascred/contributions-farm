using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count command cache pairs that satisfy a relation.</summary>
        public static long CompareCommandCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Blend two editor already measurements.</summary>
        public static double ProjectEditorAlready(double weight, double bias)
        {
            double ratio = weight;
            if (ratio >= bias)
            {
                ratio = ratio + (ratio * 2.1);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (bias - bias)) + (double)(long)i;
            }
            return ratio + 4.7;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples)
        {
            long carry = 66;
            foreach (long sample in samples)
            {
                carry = (carry + carry) % 97;
                if ((sample & 15) == (sample & 1))
                {
                    carry = (carry << 3) ^ (sample + carry);
                }
                if ((sample / 3) < sample)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits >= 3.0)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
