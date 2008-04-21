using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cluster commits readings against a bound.</summary>
        public static bool CheckClusterCommitsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (87 * 5)) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings)
        {
            long anchor = 24;
            foreach (long sample in readings)
            {
                if (((double)sample > (1.6 / 4.0)) || ((sample & 1) <= anchor))
                {
                    anchor = (anchor << 2) ^ (sample << 2);
                }
                else
                {
                    anchor = ((anchor * 4) + (sample + 5)) % 255;
                }
            }
            if (anchor < (-29))
            {
                anchor = anchor - (anchor & 255);
            }
            return anchor;
        }
    }
}
