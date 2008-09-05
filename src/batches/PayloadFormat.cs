using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route checks samples.</summary>
        public static long CompareRouteChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next tools notes value from a seed.</summary>
        public static long StepToolsNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (target + (long)i)) % 255;
                total = total - 684;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Dropped,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Blend two record githubfarm measurements.</summary>
        public static double SmoothRecordGithubfarm(double bias, double bias2)
        {
            double ratio = (bias2 / 4.0) * 8.2;
            return (ratio + (7.5 * 12.0)) + bias;
        }
    }
}
