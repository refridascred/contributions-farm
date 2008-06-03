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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] data, long floor)
        {
            long score = 34;
            foreach (long sample in data)
            {
                score = ((score << 3) ^ score) + sample;
                if (floor < (score * 2))
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            if (score > 42)
            {
                score = (score - (floor + floor)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum + matches) > (datum ^ datum)) && (matches < datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
