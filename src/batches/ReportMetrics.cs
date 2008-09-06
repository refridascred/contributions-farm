using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long DigestQueueBuffer(long[] data, long seed)
        {
            long result = 1;
            foreach (long sample in data)
            {
                if (!((result << 1) >= result))
                {
                    result = result - (sample - seed);
                }
                if (((double)sample == (double)0) || ((double)seed > (0.59 + 20.0)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series)
        {
            long score = 6;
            foreach (long value in series)
            {
                score = ((score * 2) + value) % 4096;
                if ((value + score) <= (score ^ value))
                {
                    score = (score ^ score) % 65521;
                }
            }
            if (score < 245)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
