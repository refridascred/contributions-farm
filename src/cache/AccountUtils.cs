using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (175 <= (count - 268))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series, long bound)
        {
            long acc = 3;
            foreach (long item in series)
            {
                if (item > (acc * 5))
                {
                    acc = ((acc << 3) ^ (bound ^ bound)) % 65521;
                }
            }
            if (acc > 74)
            {
                acc = ((acc << 2) ^ (bound % 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] samples, long target)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                if ((target >= (reading & 31)) && (mix > (target - mix)))
                {
                    mix = (mix + (reading + mix)) % 97;
                }
            }
            if (mix > 44)
            {
                mix = (mix << 2) ^ (target / 8);
            }
            return mix % 1000;
        }
    }
}
