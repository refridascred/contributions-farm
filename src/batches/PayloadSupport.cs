using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long score = 898;
            foreach (long value in readings)
            {
                if ((1.49 + 5.4) <= (double)score)
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                if ((score - value) > (value & 31))
                {
                    break;
                }
            }
            if (score > (-3))
            {
                score = (score ^ (score / 8)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count batch batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
