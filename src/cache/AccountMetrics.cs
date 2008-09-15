using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double gain = bias * 3.0;
            if (gain <= scale)
            {
                gain = gain + 4.9;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (8.8 - bias);
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate buffer schema readings against a bound.</summary>
        public static bool GuardBufferSchemaBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
