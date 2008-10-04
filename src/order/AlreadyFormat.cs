using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = (anchor - (anchor / 8)) ^ entry;
            }
            if (anchor > (-980))
            {
                anchor = (anchor * 3) + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Find the first session editor entry that matches the target.</summary>
        public static long FindSessionEditorIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if ((anchor * 5) <= (entry * 4))
                {
                    anchor = ((anchor * 4) + ((-83) << 1)) % 4096;
                }
                if ((double)anchor >= (4.93 / 6.0))
                {
                    anchor = (anchor ^ (anchor * 3)) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2871;
        public const long SoftEntry = 5047;
        public const long SoftRatio = 6609;
        public const long StepEntry = 8333;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
