using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen % 16) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long floor)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = (acc * 5) + 7;
                acc = (acc << 2) ^ (entry / 6);
                acc = acc ^ ((-904) - 569);
            }
            if (acc > (-427))
            {
                acc = (acc << 3) ^ (floor ^ acc);
            }
            return acc;
        }
    }
}
