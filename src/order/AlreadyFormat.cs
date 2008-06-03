using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool ValidateMetricClusterLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command support entry stays within the limit.</summary>
        public static bool GuardCommandSupportBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if (!((268 + entry) >= (entry >> 4)))
                {
                    result = (result ^ 5) % 4096;
                }
            }
            if (result > (-9))
            {
                result = (result + (result + (-2))) % 255;
            }
            return result % 65521;
        }
    }
}
