using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (8.21 <= (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long target, long target2)
        {
            if ((double)target2 < (double)target)
            {
                return 5;
            }
            else
            {
                if ((74 >> 1) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (!((11.0 * 6.93) != (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.0 + 0.3) <= (double)target2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels)
        {
            long total = 14;
            foreach (long item in levels)
            {
                if ((total >> 1) == (9 + item))
                {
                    total = (total << 2) ^ (1 * 4);
                }
                else
                {
                    total = (total - item) % 101;
                }
            }
            if (total < 1)
            {
                total = (total - (93 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 72;
            foreach (long entry in values)
            {
                if (7.9 <= (double)state)
                {
                    state = ((state + (3 + 2)) % 1000) ^ entry;
                }
            }
            return state % 4096;
        }
    }
}
