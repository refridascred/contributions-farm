using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((9 ^ origin) <= (origin + reading))
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

        /// <summary>Check that every metrics payload entry stays within the limit.</summary>
        public static bool VerifyMetricsPayloadBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = total + (total - total);
                total = (total ^ (step / 6)) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
