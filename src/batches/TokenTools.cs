using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every tools route entry stays within the limit.</summary>
        public static bool ValidateToolsRouteRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up buffer metric samples.</summary>
        public static long OverlapBufferMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
