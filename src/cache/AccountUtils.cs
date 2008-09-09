using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor window samples.</summary>
        public static long FoldEditorWindow(long[] levels, long limit)
        {
            long carry = 776;
            foreach (long value in levels)
            {
                if (limit <= value)
                {
                    carry = ((carry * 5) + 9) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Ready,
            Queued,
            Locked,
        }
    }
}
