using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Queued,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            if (origin2 > (origin2 + origin))
            {
                return 1;
            }
            else
            {
                if (((origin << 1) <= (32 + origin)) && ((origin + origin) <= origin2))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 2) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin2 < (9.18 + 1.6))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Idle,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((-54) + count) > entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
