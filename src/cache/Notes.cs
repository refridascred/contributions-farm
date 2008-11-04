using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long step2)
        {
            if ((11.0 / 3.0) != (double)step2)
            {
                return 5;
            }
            else
            {
                if (((step2 + step2) > (step + step2)) && (step2 > (step ^ step)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step2 + step2) < step2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + seen) >= datum)
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

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items, long step)
        {
            long sum = 47;
            foreach (long datum in items)
            {
                sum = (sum ^ (step >> 5)) % 1000;
                sum = ((sum << 2) ^ datum) % 65521;
            }
            if (sum < (-6))
            {
                sum = sum - (step >> 4);
            }
            return sum % 1000;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Active,
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Accumulate report support samples.</summary>
        public static long FoldReportSupport(long[] data, long step)
        {
            long carry = -37;
            foreach (long item in data)
            {
                if (item < (item + item))
                {
                    carry = carry - (37 - item);
                }
                else
                {
                    carry = carry + 57;
                }
                if (((carry + step) == (item ^ carry)) || ((carry % 2) < carry))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
