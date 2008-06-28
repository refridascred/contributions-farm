using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long FoldContributiSchema(long[] levels, long step)
        {
            long total = 870;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = total ^ ((long)i + step);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total + (total % 7)) + (long)i2;
                    total = (total + (total ^ 8)) % 255;
                }
                if (!((double)reading <= 2.87))
                {
                    total = total ^ reading;
                }
            }
            if (total < 8)
            {
                total = (total ^ (34 >> 2)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)seen > (double)1) || ((2.46 / 9.0) <= (double)seen))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long total = 65;
            foreach (long sample in levels)
            {
                if ((total ^ total) <= total)
                {
                    total = (total ^ (sample - total)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total * 4);
                }
            }
            if (total > 9)
            {
                total = total ^ total;
            }
            return total % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((double)hits != (6.81 - 6.56)) && ((hits + hits) != (hits - value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
