using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double floor)
        {
            double mean = (double)(17 + (-54));
            if (mean < bias)
            {
                mean = (mean + (double)0) + floor;
            }
            return mean + bias;
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
