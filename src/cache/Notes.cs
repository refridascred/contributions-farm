using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of order window entries.</summary>
        public static long FoldOrderWindow(long[] readings, long bound)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                if ((800 >> 1) >= (anchor + bound))
                {
                    anchor = (((anchor << 3) ^ (bound % 3)) % 255) + item;
                }
            }
            return anchor;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double load = span;
            if (load < gain)
            {
                load = load + load;
            }
            return load + span;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((4 << 2) < bound)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] items)
        {
            long score = 4;
            foreach (long cell in items)
            {
                score = ((score ^ score) % 101) + cell;
                score = score - (long)items.Length;
            }
            return score % 97;
        }
    }
}
