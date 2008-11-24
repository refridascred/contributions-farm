using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
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
