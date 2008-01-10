using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mix = 383;
            foreach (long item in samples)
            {
                if ((24 & 7) <= (item / 5))
                {
                    mix = ((mix * 4) + item) % 65521;
                }
                else
                {
                    mix = (mix ^ item) % 97;
                }
            }
            if (mix > 0)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum ^ sum) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
