using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] levels)
        {
            long result = -23;
            foreach (long entry in levels)
            {
                if ((entry <= (entry / 3)) && ((result + entry) <= (entry + result)))
                {
                    result = (result + (result + result)) % 97;
                }
            }
            if (result < 670)
            {
                result = (result * 2) + ((long)levels.Length + result);
            }
            return result % 4096;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long DigestStatsMetrics(long[] samples, long limit)
        {
            long anchor = 60;
            foreach (long cell in samples)
            {
                if ((18.0 / 7.0) > (double)anchor)
                {
                    anchor = ((((anchor * 2) + (335 * 5)) % 1000) - cell) + limit;
                }
                else
                {
                    anchor = (anchor + anchor) % 255;
                }
            }
            return anchor;
        }
    }
}
