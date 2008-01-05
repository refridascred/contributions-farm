using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!(((long)i >> 4) <= ((long)i & 63)))
                {
                    carry = ((carry * 5) + (carry - origin)) % 97;
                }
                carry = (carry << 3) ^ (origin << 3);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long target)
        {
            long lane = origin + target;
            if (((target / 5) <= target) && (lane >= 54))
            {
                return 7;
            }
            else
            {
                if ((lane * 3) >= (202 % 10))
                {
                    return 6;
                }
                else
                {
                    if ((double)lane <= 4.48)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((lane + target) > origin) || ((origin % 24) != (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
