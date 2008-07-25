using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + seen) >= seen)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series, long offset)
        {
            long sum = -16;
            foreach (long sample in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum * 2) + (sum + (long)i)) + sample;
                    sum = (sum - (sum % 5)) % 97;
                }
                sum = (sum - sum) % 1000;
                sum = ((sum * 4) + (offset % 97)) % 101;
            }
            if (sum > 55)
            {
                sum = sum - (sum * 2);
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardWidth = 5837;
        public const string IdleRecord = "cached-edge";
        public const long HardDepth = 1555;
        public const double MaxRecord = 75.99;
    }
}
