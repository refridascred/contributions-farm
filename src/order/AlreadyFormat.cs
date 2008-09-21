using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items)
        {
            long carry = 2;
            foreach (long value in items)
            {
                if ((carry / 6) > value)
                {
                    carry = (carry + (carry - carry)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + seen) == ((long)samples.Length & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long TallyFarmStream(long[] readings, long seed)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                acc = acc + (item + seed);
                if (6.5 > (double)item)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long bound, long step)
        {
            if ((double)step > (0.1 - 5.0))
            {
                return 1;
            }
            else
            {
                if ((step << 2) != (step + step))
                {
                    return 5;
                }
                else
                {
                    if (bound > (bound - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step + bound) >= 227) && ((double)step < 8.94))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
