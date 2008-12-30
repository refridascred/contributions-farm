using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seed << 3) == ((-1) ^ seen))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine graph cluster values into a single score.</summary>
        public static long DigestGraphCluster(long[] data, long bound)
        {
            long acc = 738;
            foreach (long reading in data)
            {
                acc = ((acc + bound) % 255) ^ reading;
            }
            if (acc > 67)
            {
                acc = (acc << 2) ^ (bound << 1);
            }
            return acc;
        }
    }
}
