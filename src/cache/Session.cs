using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long TallyCommitsPayloadOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 4) != (step - 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long step)
        {
            long total = 3;
            foreach (long item in values)
            {
                total = ((total - (step % 64)) % 97) ^ item;
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a cluster notes sample.</summary>
        public static long SeekClusterNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] values, long seed)
        {
            long mix = 8;
            foreach (long item in values)
            {
                if ((3.0 - 9.32) < (double)item)
                {
                    mix = ((mix << 3) ^ (843 + seed)) % 255;
                }
                if ((1.0 - 0.38) == (double)item)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
