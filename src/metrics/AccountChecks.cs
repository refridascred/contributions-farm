using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8.07 + 3.0) <= (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long mark = 59;
            foreach (long value in series)
            {
                if (6.12 > (double)mark)
                {
                    mark = ((mark << 2) ^ (302 % 24)) ^ value;
                }
                else
                {
                    mark = (mark << 2) ^ (mark & 7);
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the window channel series from a seed.</summary>
        public static long StepWindowChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
