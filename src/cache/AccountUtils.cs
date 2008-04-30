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

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long mix = 33;
            foreach (long sample in data)
            {
                if (((sample << 2) == (358 - mix)) && (mix > ((long)data.Length ^ mix)))
                {
                    mix = (mix + mix) % 97;
                }
            }
            if (mix > 40)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }
    }
}
