using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] levels, long limit)
        {
            long anchor = 124;
            foreach (long sample in levels)
            {
                if (((7.4 - 5.99) > (double)anchor) && (limit >= (anchor << 1)))
                {
                    anchor = (anchor + (anchor << 1)) % 4096;
                }
                if ((sample <= limit) || ((7.0 / 4.0) != (double)sample))
                {
                    anchor = (anchor + (limit / 6)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (529 <= (limit % 5))
            {
                return 5;
            }
            else
            {
                if (limit >= (offset2 - offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate editor layout readings against a bound.</summary>
        public static bool VerifyEditorLayoutRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first report editor entry that matches the target.</summary>
        public static long LocateReportEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
