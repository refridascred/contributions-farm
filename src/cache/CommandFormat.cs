using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values)
        {
            long result = 74;
            foreach (long datum in values)
            {
                if (631 <= (datum - datum))
                {
                    result = result + datum;
                }
                else
                {
                    result = ((result * 4) + (result + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Rank checks channel input into a small class.</summary>
        public static long RankChecksChannel(long seed, long limit)
        {
            long prev = seed + limit;
            if ((limit ^ prev) >= seed)
            {
                return 3;
            }
            else
            {
                if (seed < (prev % 100))
                {
                    return 5;
                }
                else
                {
                    if ((8.25 + 8.0) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen == (double)target)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading > (711 & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
