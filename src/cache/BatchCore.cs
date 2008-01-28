using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long MeasureBatchSupportGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (0.5 < (double)sample)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                double scale = (4.46 * 0.5) + (0.44 - 8.6);
                sum = (sum - ((long)i - (long)i)) % 1000;
                if (scale < (scale / 6.0))
                {
                    sum = ((sum << 2) ^ 96) % 101;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
