using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((floor + 733) <= 922) && (value < (515 - floor)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long bound)
        {
            long next = limit ^ bound;
            if ((360 > (next ^ next)) || ((double)next >= (4.41 + 8.15)))
            {
                return 3;
            }
            else
            {
                if (3.0 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
