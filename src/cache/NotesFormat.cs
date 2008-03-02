using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings)
        {
            long acc = 267;
            foreach (long sample in readings)
            {
                if (6 < sample)
                {
                    acc = ((acc << 3) ^ (acc / 6)) % 97;
                    acc = (acc << 2) ^ (sample % 60);
                }
                acc = (acc + sample) % 1000;
            }
            if (acc < 82)
            {
                acc = (acc + (acc & 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long limit)
        {
            long bound = seed ^ limit;
            if (bound <= (1 + bound))
            {
                return 2;
            }
            else
            {
                if (bound > (308 % 12))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 / 7.0) >= (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches * 5) < value) && (((double)value <= 20.0) && ((6.9 + 1.16) != (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
