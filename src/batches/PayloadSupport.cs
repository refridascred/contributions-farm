using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - sample) == ((long)readings.Length << 1))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long MeasureCommitsTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long floor, long floor2)
        {
            if ((floor2 + floor) > (floor ^ floor))
            {
                return 2;
            }
            else
            {
                if (((double)floor < (1.7 * 4.69)) && ((double)53 <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor2 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(floor2 >= (22 + floor2)))
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
}
