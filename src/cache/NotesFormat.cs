using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                if (((117 - mark) > target) || ((24 % 5) < target))
                {
                    mark = mark - (mark ^ target);
                }
                else
                {
                    mark = ((mark << 3) ^ (long)i) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a window record reading by value.</summary>
        public static long SeekWindowRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report checks samples.</summary>
        public static long ScoreReportChecks(long[] samples)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = ((state ^ state) % 101) - entry;
            }
            return state;
        }
    }
}
