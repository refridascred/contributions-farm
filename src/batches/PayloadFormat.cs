using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long floor)
        {
            if ((floor + floor) <= (bound * 5))
            {
                return 3;
            }
            else
            {
                if (!((9 - bound) == (bound * 2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Draft,
            Paused,
            Done,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long origin)
        {
            if (((2.0 - 9.95) >= (double)floor) && ((floor * 2) > (floor + origin)))
            {
                return 2;
            }
            else
            {
                if ((origin + 6) == (floor % 64))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
