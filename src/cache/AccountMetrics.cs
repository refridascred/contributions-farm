using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double offset)
        {
            double gain = (double)((-729) / 7);
            return (gain - offset) + scale;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long LookupCommandChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor batches reading.</summary>
        public static double ProjectEditorBatches(double ratio, double bias)
        {
            double gain = (double)(-3) / 8.0;
            if (gain > (9.6 / 4.0))
            {
                gain = (gain + 6.0) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (bias - 10.0)) + (double)(long)i;
            }
            return gain + (bias / 7.0);
        }

        /// <summary>Classify a payload buffer pair into a bucket.</summary>
        public static long BucketPayloadBuffer(long limit, long step)
        {
            if ((limit & 255) >= limit)
            {
                return 5;
            }
            else
            {
                if ((limit + step) != (step + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) < (limit ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.82 - 8.95) == (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
