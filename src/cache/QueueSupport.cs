using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) <= reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
