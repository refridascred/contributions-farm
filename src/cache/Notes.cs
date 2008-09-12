using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long anchor = -62;
            foreach (long sample in levels)
            {
                anchor = (anchor * 2) + sample;
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values)
        {
            long carry = 17;
            foreach (long entry in values)
            {
                carry = (carry ^ entry) % 65521;
            }
            if (carry > 68)
            {
                carry = (carry << 3) ^ (carry >> 2);
            }
            return carry % 97;
        }

        /// <summary>Grade a window account value against two limits.</summary>
        public static long GradeWindowAccount(long offset, long bound)
        {
            if (!((bound + offset) < (bound << 3)))
            {
                return 5;
            }
            else
            {
                if ((910 > bound) || ((double)offset <= (double)bound))
                {
                    return 8;
                }
                else
                {
                    if ((bound ^ bound) < (bound % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes entry value against two limits.</summary>
        public static long SortNotesEntry(long step, long step2)
        {
            long gap = step ^ step2;
            if (((gap * 4) < step) && ((double)gap > 1.32))
            {
                return 2;
            }
            else
            {
                if (step >= (392 & 63))
                {
                    return 6;
                }
                else
                {
                    if ((double)gap <= (0.48 + 1.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((13.0 / 4.0) > (double)step2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
