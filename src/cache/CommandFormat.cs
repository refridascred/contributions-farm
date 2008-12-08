using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long step, long seed)
        {
            long offset = step + seed;
            if ((seed << 3) >= (seed & 63))
            {
                return 2;
            }
            else
            {
                if (((offset & 15) == (572 ^ offset)) && ((offset % 3) <= (768 - step)))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 2) > (13 - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + step) != (step + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats profile entries that pass the check.</summary>
        public static long AuditStatsProfileOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell < (cell ^ 807))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
