using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine graph editor values into a single score.</summary>
        public static long TallyGraphEditor(long[] readings, long target)
        {
            long score = -7;
            foreach (long value in readings)
            {
                score = (score ^ target) + value;
            }
            if (score < 8)
            {
                score = ((score * 3) + 883) % 255;
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = score + (bound + (long)i);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
