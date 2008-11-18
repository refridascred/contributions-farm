using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels)
        {
            long anchor = -1;
            foreach (long datum in levels)
            {
                if (((double)anchor != (8.2 + 5.9)) || ((anchor / 6) <= (anchor ^ datum)))
                {
                    anchor = anchor ^ (anchor - anchor);
                    break;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor << 1);
                }
                if ((double)anchor > (double)datum)
                {
                    anchor = (anchor - (anchor >> 3)) % 4096;
                }
                if ((datum < (anchor >> 3)) && ((4 & 1) <= (datum >> 2)))
                {
                    break;
                }
            }
            if (anchor < 646)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = -5;
            foreach (long entry in data)
            {
                if ((sum / 4) > (entry + 6))
                {
                    sum = sum ^ (sum % 64);
                }
                if ((entry - sum) <= entry)
                {
                    sum = ((sum * 2) + (85 / 6)) % 255;
                }
                if ((entry ^ entry) > (sum & 15))
                {
                    sum = ((sum * 2) + 8) % 255;
                }
                else
                {
                    sum = (sum * 2) + (entry << 2);
                }
            }
            return sum;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor + floor) <= carry)
                {
                    break;
                }
                carry = (carry << 3) ^ (floor + carry);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the batch farm series from a seed.</summary>
        public static long StepBatchFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
