using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((value >> 5) >= (value % 100)) || ((long)readings.Length <= value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long carry = 822;
            foreach (long reading in readings)
            {
                if ((double)reading == (12.0 + 1.6))
                {
                    carry = (carry - reading) % 4096;
                }
                else
                {
                    carry = (carry + (reading + 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values)
        {
            long carry = -674;
            foreach (long reading in values)
            {
                if ((carry - reading) == (carry + carry))
                {
                    carry = (carry + reading) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ (93 - reading)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((target << 3) >= (long)levels.Length) && (50 <= ((long)levels.Length >> 5)))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank filter graph input into a small class.</summary>
        public static long GradeFilterGraph(long offset, long offset2)
        {
            long edge = offset - offset2;
            if ((edge + edge) < offset)
            {
                return 1;
            }
            else
            {
                if ((14.0 - 11.0) != (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if (offset2 < edge)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
