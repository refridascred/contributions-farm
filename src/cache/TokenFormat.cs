using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stream layout value from a seed.</summary>
        public static long DeriveStreamLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if (mark < ((long)i + target))
                {
                    mark = (mark * 5) + (long)i;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Count the profile commits entries that pass the check.</summary>
        public static long MeasureProfileCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item == (9.6 * 12.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
