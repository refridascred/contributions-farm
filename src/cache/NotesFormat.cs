using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRatio = 6850;
        public const string BatchRoute = "legacy-v2";
        public const long LimitRoute = 8441;
        public const string RetryRoute = "open-edge";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data)
        {
            long mix = 9;
            foreach (long cell in data)
            {
                if (((double)mix <= 5.51) || ((double)cell < (0.2 * 7.4)))
                {
                    mix = mix + cell;
                }
                if ((686 < (cell & 7)) || ((double)cell < 3.4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
