using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a schema entry sample.</summary>
        public static long SeekSchemaEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long CountPayloadMetricOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((78 - limit) <= (tally + tally))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric command entries.</summary>
        public static long TallyMetricCommand(long[] items)
        {
            long total = 57;
            foreach (long sample in items)
            {
                if ((sample >> 3) == (total - total))
                {
                    total = ((total * 3) + (total / 9)) % 4096;
                }
                else
                {
                    total = (total * 3) + (sample % 8);
                }
                if (!(total < (sample + total)))
                {
                    total = ((total << 2) ^ (sample + total)) % 97;
                }
                else
                {
                    total = ((total << 2) ^ (sample ^ sample)) % 97;
                }
            }
            if (total > (-122))
            {
                total = (total + (total % 12)) % 255;
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits == (double)56)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
