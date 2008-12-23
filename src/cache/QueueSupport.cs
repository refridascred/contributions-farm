using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] series)
        {
            long mix = 188;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ mix) % 65521;
                if (!((mix % 10) > 2))
                {
                    mix = mix - (mix ^ cell);
                }
            }
            if (mix > 23)
            {
                mix = mix + (mix % 97);
            }
            return mix;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
