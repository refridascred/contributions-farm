using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Done,
            Ready,
            Idle,
            New,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((score / 8) != (offset - (long)i))
                {
                    score = ((score * 5) + (offset * 4)) % 255;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryScore = 67.29;
        public const string WindowTimeout = "fallback";
        public const long CacheQueue = 5449;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Ready,
            Queued,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long seed)
        {
            long span = origin + seed;
            if ((span & 1) != (seed + span))
            {
                return 8;
            }
            else
            {
                if ((span ^ origin) >= (span / 5))
                {
                    return 1;
                }
                else
                {
                    if ((span + seed) <= (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (span < (88 % 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
