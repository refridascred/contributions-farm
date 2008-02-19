using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long AuditSupportEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + reading) >= (-95))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(score >= floor))
                {
                    score = (score << 3) ^ ((long)i % 3);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a contributi profile pair into a bucket.</summary>
        public static long BucketContributiProfile(long seed, long bound)
        {
            if (!((seed - 562) < ((-297) >> 3)))
            {
                return 8;
            }
            else
            {
                if ((seed >= ((-8) - seed)) || ((double)bound >= 6.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
