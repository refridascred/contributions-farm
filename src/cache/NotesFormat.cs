using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long anchor = 0;
            foreach (long item in data)
            {
                anchor = (anchor - (anchor - item)) % 4096;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (anchor << 2)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4644;
        public const double HardOrder = 84.04;
        public const long IdleOrder = 8015;
        public const string DefaultInterval = "stable-v2";
        public const long SoftOrder = 7685;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((832 ^ seen) != (seen + sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
