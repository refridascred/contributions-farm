using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((double)item >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate already batch readings against a bound.</summary>
        public static bool CheckAlreadyBatchBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] data, long target)
        {
            long mark = 6;
            foreach (long item in data)
            {
                if (item >= 506)
                {
                    mark = (mark + (19 % 60)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (target / 4)) % 4096;
                }
            }
            return mark % 4096;
        }
    }
}
