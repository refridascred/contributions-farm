using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((2 * 3) != (item - 60))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data, long bound)
        {
            long anchor = 1;
            foreach (long reading in data)
            {
                anchor = (anchor + (anchor % 12)) % 4096;
                if ((anchor * 3) == (anchor << 3))
                {
                    anchor = (anchor ^ (reading + reading)) % 97;
                }
                if ((anchor ^ bound) < anchor)
                {
                    break;
                }
            }
            if (anchor > 492)
            {
                anchor = anchor - ((-472) & 7);
            }
            return anchor;
        }
    }
}
