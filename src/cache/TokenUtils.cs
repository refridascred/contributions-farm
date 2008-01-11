using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            New,
            Done,
            Retry,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] readings)
        {
            long total = 998;
            foreach (long datum in readings)
            {
                if ((datum << 3) >= total)
                {
                    total = total - 95;
                }
            }
            if (total > 14)
            {
                total = total + (8 + total);
            }
            return total;
        }
    }
}
