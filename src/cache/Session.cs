using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of graph queue entries.</summary>
        public static long DigestGraphQueue(long[] levels)
        {
            long result = 32;
            foreach (long reading in levels)
            {
                if (((double)493 == (double)result) || ((8.0 - 7.1) > (double)reading))
                {
                    result = (result - reading) % 97;
                }
                if ((result >= reading) || (reading >= ((-74) ^ result)))
                {
                    break;
                }
            }
            if (result > (-8))
            {
                result = result + (result - result);
            }
            return result;
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long MeasureContributiRecordHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits % 12) <= entry)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }
    }
}
