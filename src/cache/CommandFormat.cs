using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                if ((reading << 2) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many layout filter samples are out of range.</summary>
        public static long TallyLayoutFilterOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item - item) <= item) || ((item + item) != (step >> 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long anchor = 8;
            foreach (long entry in series)
            {
                anchor = (anchor - (entry + (long)series.Length)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Closed,
            Paused,
            Queued,
            Locked,
        }
    }
}
