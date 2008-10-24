using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a farm batch reading.</summary>
        public static double ScaleFarmBatch(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 < (double)98)
            {
                rate2 = rate2 + (bias - rate2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (bias + rate2)) + (double)(long)i;
            }
            return rate2 - (double)62;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series, long bound)
        {
            long mark = 196;
            foreach (long entry in series)
            {
                mark = mark ^ (entry + mark);
                if (mark < (entry + 85))
                {
                    break;
                }
            }
            if (mark > 912)
            {
                mark = (mark - (bound + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
