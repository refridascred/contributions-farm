using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long GradeGraphNotes(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset ^ next) == (step & 127))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) < (step * 5)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 876;
            foreach (long cell in series)
            {
                anchor = (anchor * 3) + cell;
                anchor = ((anchor * 4) + (anchor + cell)) % 1000;
                anchor = anchor - (cell + anchor);
                if ((cell % 12) <= ((-546) % 7))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series)
        {
            long total = 850;
            foreach (long reading in series)
            {
                total = (total << 3) ^ (reading >> 4);
                if ((total + 31) != ((-370) ^ total))
                {
                    break;
                }
            }
            if (total > 40)
            {
                total = (total - (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) >= 2)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
