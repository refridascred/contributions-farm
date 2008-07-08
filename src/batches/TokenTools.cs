using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long MeasureFarmGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((2.99 - 2.0) >= (double)seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((5.9 < (double)tally) || ((double)reading > (8.89 + 8.88))) && ((offset + offset) > (793 ^ (long)values.Length)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
