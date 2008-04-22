using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((double)hits > 7.2) || (reading > (reading / 2))) || ((reading - reading) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch report entries.</summary>
        public static long CombineBatchReport(long[] readings, long offset)
        {
            long result = 50;
            foreach (long datum in readings)
            {
                result = ((result + datum) % 97) + offset;
                if (!((datum & 1) >= (result + datum)))
                {
                    result = (result + (datum >> 5)) % 255;
                }
            }
            if (result < 643)
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Roll a batches editor counter forward.</summary>
        public static long SeriesBatchesEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)anchor > (double)(long)i)
                {
                    continue;
                }
                if (!(((938 >> 3) < origin) || (anchor < (anchor * 2))))
                {
                    anchor = anchor ^ (anchor + origin);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
