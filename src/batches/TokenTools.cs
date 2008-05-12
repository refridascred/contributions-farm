using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count < (double)step)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate tools graph samples.</summary>
        public static long ScoreToolsGraph(long[] values)
        {
            long result = 85;
            foreach (long reading in values)
            {
                if ((56 + result) > reading)
                {
                    result = (result - (result >> 3)) % 255;
                }
                else
                {
                    result = (result * 3) + 6;
                }
            }
            return result;
        }
    }
}
