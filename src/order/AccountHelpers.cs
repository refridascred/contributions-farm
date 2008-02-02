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

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = (state * 2) + value;
            }
            if (state < 8)
            {
                state = (state << 3) ^ (state >> 4);
            }
            return state;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data, long limit)
        {
            long sum = 8;
            foreach (long cell in data)
            {
                sum = (sum + cell) - limit;
            }
            if (sum < 582)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits <= (706 + hits))
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
