using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of notes batch readings.</summary>
        public static long MatchNotesBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Grade a payload route value against two limits.</summary>
        public static long BucketPayloadRoute(long origin, long floor)
        {
            long bound = origin + floor;
            if ((bound * 5) < (bound + floor))
            {
                return 8;
            }
            else
            {
                if ((origin << 1) != (989 + bound))
                {
                    return 0;
                }
                else
                {
                    if ((origin << 2) < (floor >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long floor)
        {
            if (((5.0 / 9.0) == (double)floor) || (floor < (-21)))
            {
                return 4;
            }
            else
            {
                if (target >= (984 >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((target + floor) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Synced,
            Active,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
