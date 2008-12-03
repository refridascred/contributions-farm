using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long MeasureCacheAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length != (seen - 218))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data, long floor)
        {
            long anchor = 27;
            foreach (long datum in data)
            {
                if ((anchor - datum) < anchor)
                {
                    anchor = anchor + floor;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor + floor) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many editor checks samples are out of range.</summary>
        public static long AuditEditorChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((6.07 * 8.55) != (double)tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
