using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum << 1) <= (tally ^ datum)) || (tally >= (tally >> 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long offset)
        {
            long cur = origin - offset;
            if (!((cur >> 2) < (offset >> 4)))
            {
                return 8;
            }
            else
            {
                if ((double)cur != (19.0 * 11.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 2) >= (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + origin) < (offset / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
