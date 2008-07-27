using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Active,
            Failed,
            New,
            Synced,
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Rank commits command input into a small class.</summary>
        public static long SortCommitsCommand(long floor, long floor2)
        {
            if (936 <= (floor2 & 255))
            {
                return 3;
            }
            else
            {
                if (!((floor2 & 63) > (floor ^ floor2)))
                {
                    return 1;
                }
                else
                {
                    if (!((6.36 - 5.0) == (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((34 * 3) == (floor2 ^ floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Retry,
            Ready,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            Stale,
        }
    }
}
