using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate token payload readings against a bound.</summary>
        public static bool VerifyTokenPayloadBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up metric layout samples.</summary>
        public static long OverlapMetricLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
