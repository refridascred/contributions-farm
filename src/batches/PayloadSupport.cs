using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many format editor samples are out of range.</summary>
        public static long MeasureFormatEditorMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((target + reading) > reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum * 4) >= (datum & 255))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
