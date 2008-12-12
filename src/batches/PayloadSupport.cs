using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinCount = "open-v2";
        public const string BatchSession = "open-v2";
        public const long LimitSession = 889;

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((2.0 / 3.0) > (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
