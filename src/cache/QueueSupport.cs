using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double mean = scale / 2.0;
            if (mean > (span / 2.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (double)39;
            }
            return mean - span;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + (long)samples.Length) == (item - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
