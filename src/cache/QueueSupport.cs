using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long bound)
        {
            if ((bound ^ bound) == (59 ^ 17))
            {
                return 7;
            }
            else
            {
                if ((bound << 2) >= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if ((420 / 7) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long floor)
        {
            long mix = 890;
            foreach (long entry in data)
            {
                if ((entry < (floor / 9)) && (962 > (mix + entry)))
                {
                    mix = (mix ^ entry) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (mix % 100);
                }
                if ((6.5 * 3.0) <= (double)entry)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
