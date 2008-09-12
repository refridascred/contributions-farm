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

        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long SeriesClusterCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry * 5) + (floor + 304)) % 97) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            Idle,
            Failed,
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
