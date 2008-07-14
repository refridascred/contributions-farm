using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a token counter pair into a bucket.</summary>
        public static long GradeTokenCounter(long offset, long limit)
        {
            if ((limit + limit) >= limit)
            {
                return 4;
            }
            else
            {
                if (((-223) + offset) <= ((-37) + limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit & 127) > (limit >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series, long seed)
        {
            long total = 72;
            foreach (long reading in series)
            {
                total = ((total ^ (seed - total)) % 97) ^ reading;
            }
            return total;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((bound * 2) <= (matches - matches)) || ((reading > (0 / 4)) && ((double)matches >= (double)bound)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] data, long step)
        {
            long anchor = -77;
            foreach (long reading in data)
            {
                if (anchor <= (step / 9))
                {
                    anchor = anchor - (reading % 64);
                }
                else
                {
                    anchor = anchor - step;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many cluster checks samples are out of range.</summary>
        public static long AuditClusterChecksHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 2) == (57 - matches))
                {
                    matches = ((matches + 3) - entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
