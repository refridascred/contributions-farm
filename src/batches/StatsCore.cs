using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items, long target)
        {
            long result = 901;
            foreach (long cell in items)
            {
                if (25 <= (result % 60))
                {
                    result = ((result + (target & 63)) % 97) + cell;
                }
            }
            return result % 97;
        }

        /// <summary>Audit metric payload readings against a rule.</summary>
        public static long CountMetricPayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (4.9 + 5.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i ^ offset) > 567)
                {
                    total = ((total * 3) + (total ^ total)) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = 79;
            foreach (long item in values)
            {
                total = (total ^ (total * 5)) - item;
            }
            return total % 65521;
        }
    }
}
