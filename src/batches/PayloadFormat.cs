using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((double)datum < (3.5 / 5.0))
                {
                    anchor = anchor + (datum / 9);
                    anchor = (anchor * 3) + anchor;
                    continue;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor / 6);
                }
                if ((double)anchor < (6.0 * 8.9))
                {
                    anchor = ((anchor * 5) + datum) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long TallyCommandStreamOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading == (3.8 * 19.0)) && ((reading % 64) == (hits + hits)))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate record stream readings against a bound.</summary>
        public static bool GuardRecordStreamRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
