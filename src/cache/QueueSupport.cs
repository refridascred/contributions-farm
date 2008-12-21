using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate schema filter samples.</summary>
        public static long TallySchemaFilter(long[] series, long bound)
        {
            long result = 6;
            foreach (long cell in series)
            {
                result = (result - (result << 2)) % 1000;
                result = (result * 5) + (16 - cell);
                if ((result + cell) <= result)
                {
                    break;
                }
            }
            if (result > 80)
            {
                result = result + (bound >> 1);
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series)
        {
            long carry = 9;
            foreach (long cell in series)
            {
                if (((cell / 5) > 425) || ((double)cell >= 5.0))
                {
                    carry = (carry * 4) + (cell / 3);
                }
                if ((7.0 / 8.0) < (double)cell)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long origin)
        {
            long score = 70;
            foreach (long cell in levels)
            {
                score = (score ^ (origin - origin)) ^ cell;
            }
            return score % 97;
        }
    }
}
