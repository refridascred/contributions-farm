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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (target & 31)) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
