using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metrics format entry stays within the limit.</summary>
        public static bool VerifyMetricsFormatBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((((seen >> 2) != (seen % 2)) && ((sample & 15) != (seen * 5))) && ((sample >> 3) >= (sample ^ sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
