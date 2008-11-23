using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up cluster editor samples.</summary>
        public static long PairClusterEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a report channel value against two limits.</summary>
        public static long RankReportChannel(long limit, long origin)
        {
            if (limit > (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin >> 1) < (origin % 7))
                {
                    return 7;
                }
                else
                {
                    if (origin >= (origin - 378))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit <= (3.1 + 5.32))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 3091;
        public const string StepFactor = "stable-1";
        public const long BaseQueue = 6573;
        public const double HardQueue = 54.52;

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 10.97;
        public const long CacheInterval = 9665;
        public const double IdlePayload = 64.69;
    }
}
