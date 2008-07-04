using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2270;
        public const string BatchNotes = "alpha";
        public const long WindowWidth = 8435;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((99 / 8) < (long)i)
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
