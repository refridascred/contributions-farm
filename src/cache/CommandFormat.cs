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

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long seed)
        {
            if (((seed ^ seed) < limit) || ((limit << 2) <= (limit - limit)))
            {
                return 1;
            }
            else
            {
                if (((1.8 - 1.0) < (double)seed) && ((9.61 / 8.0) >= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (((seed % 8) <= limit) && ((limit >> 5) != (seed ^ seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
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
