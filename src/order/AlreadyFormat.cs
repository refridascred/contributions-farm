using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate counter token readings against a bound.</summary>
        public static bool GuardCounterTokenBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] items)
        {
            long result = 4;
            foreach (long sample in items)
            {
                if (!(((long)items.Length << 1) >= sample))
                {
                    result = ((result * 3) + (2 / 9)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Count the profile filter entries that pass the check.</summary>
        public static long MeasureProfileFilterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 16) == (tally - tally))
                {
                    tally = ((tally + 3) - reading) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long origin)
        {
            long score = 2;
            foreach (long cell in levels)
            {
                if ((origin * 4) > 33)
                {
                    score = ((score << 3) ^ 640) % 97;
                    break;
                }
                else
                {
                    long slot = score;
                    score = (score - (7 ^ slot)) % 65521;
                }
                if ((cell << 1) <= (score + origin))
                {
                    score = score + score;
                }
                else
                {
                    score = score + (score / 3);
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Stale,
            Failed,
            Draft,
            Active,
        }
    }
}
