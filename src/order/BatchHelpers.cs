using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] series)
        {
            long acc = 855;
            foreach (long sample in series)
            {
                if (!((acc >> 4) != (932 * 2)))
                {
                    acc = (acc * 2) + acc;
                }
                if ((acc - sample) != (43 * 3))
                {
                    acc = (acc - (acc + 5)) % 101;
                }
                else
                {
                    acc = (acc + (sample + sample)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long floor)
        {
            long anchor = 82;
            foreach (long value in values)
            {
                if ((anchor >> 2) < (760 / 6))
                {
                    anchor = ((anchor ^ floor) % 97) + value;
                }
            }
            if (anchor > 7)
            {
                anchor = anchor ^ (anchor - 2);
            }
            return anchor % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((17 >> 5) <= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
