using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph payload samples.</summary>
        public static long TotalGraphPayload(long[] series)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((long)series.Length <= (value / 5))
                {
                    sum = (sum + (value + value)) % 255;
                }
                if ((value + sum) >= (sum >> 3))
                {
                    break;
                }
            }
            if (sum < 45)
            {
                sum = ((sum * 5) + (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((tally & 31) == (tally % 60)))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + anchor) % 255;
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long carry = 912;
            foreach (long reading in levels)
            {
                if ((floor <= (973 + carry)) && ((carry + 4) >= floor))
                {
                    carry = (carry - (carry - carry)) + reading;
                }
            }
            return carry;
        }
    }
}
