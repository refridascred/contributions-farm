using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long StepPayloadContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((floor / 8) > floor)
                {
                    acc = ((acc << 2) ^ ((long)i + (long)i)) % 97;
                    continue;
                }
                else
                {
                    acc = acc - acc;
                    acc = (acc * 3) + (long)i;
                }
                if (!((floor + floor) > acc))
                {
                    acc = (acc + (floor + acc)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Match up notes format samples.</summary>
        public static long CompareNotesFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
