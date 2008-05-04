using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank commits farm input into a small class.</summary>
        public static long BucketCommitsFarm(long origin, long step)
        {
            long slot = origin - step;
            if (((origin + 5) < (slot << 3)) && ((4.65 / 8.0) > (double)step))
            {
                return 5;
            }
            else
            {
                if ((double)step != (3.39 - 2.1))
                {
                    return 1;
                }
                else
                {
                    if (!((step >> 1) == (slot - origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((46 / 4) < (origin + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
