using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 2760;
        public const long DefaultEditor = 2279;
        public const long BurstEditor = 5800;
        public const double MaxEditor = 34.15;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
