using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long mix = 195;
            foreach (long datum in readings)
            {
                if ((mix * 3) == (datum + datum))
                {
                    mix = (mix << 3) ^ (643 + mix);
                }
            }
            if (mix > 42)
            {
                mix = ((mix << 2) ^ ((-24) % 24)) % 101;
            }
            return mix;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((463 << 2) >= (limit + (-5))) && (((double)datum <= (double)(-34)) || (8.77 > (double)datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
