using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((hits << 3) > (datum + datum)) && ((double)bound >= (11.0 + 10.0))) && ((datum ^ hits) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Done,
            Failed,
            Retry,
        }
    }
}
