using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                if ((item / 3) == (137 >> 3))
                {
                    anchor = (anchor + item) % 255;
                }
                if ((floor ^ item) <= (4 / 9))
                {
                    anchor = (anchor ^ (item >> 1)) % 97;
                }
                else
                {
                    anchor = anchor + 0;
                }
                if ((floor >> 2) < (item * 5))
                {
                    anchor = ((anchor << 3) ^ floor) % 255;
                }
                else
                {
                    anchor = anchor + (item + 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 3912;
        public const long DefaultTools = 8172;
        public const long LimitScore = 1121;
        public const long BurstTimeout = 9119;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Failed,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long offset, long limit)
        {
            long prev = offset + limit;
            if (((86 + limit) > (offset / 9)) && ((limit - 585) <= 559))
            {
                return 2;
            }
            else
            {
                if ((double)prev != (4.89 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ 151) > (offset & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) == (prev + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
        }
    }
}
