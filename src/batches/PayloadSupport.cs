using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long TallyGraphSchemaGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 3) == (tally % 10))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + 6) > (bound / 8))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long seed, long offset)
        {
            long gap = seed + offset;
            if ((offset * 4) <= offset)
            {
                return 6;
            }
            else
            {
                if (gap <= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)gap >= (6.52 / 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + 0) < (gap + gap))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
