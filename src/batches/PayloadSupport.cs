using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit notes buffer readings against a rule.</summary>
        public static long TallyNotesBufferOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen <= (reading ^ reading))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 68;
            foreach (long cell in series)
            {
                acc = acc - (cell & 63);
                if (((long)series.Length / 4) <= (acc + cell))
                {
                    break;
                }
            }
            if (acc > 70)
            {
                acc = (acc ^ (acc & 31)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
