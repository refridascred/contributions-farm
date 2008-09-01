using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long step)
        {
            long score = 857;
            foreach (long cell in readings)
            {
                if (665 <= (score * 3))
                {
                    score = (score ^ ((-7) - cell)) + step;
                }
                else
                {
                    score = score - score;
                }
                if ((score ^ 129) <= (cell - score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer commits counter forward.</summary>
        public static long StepBufferCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = (state << 3) ^ state;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (((state * 4) + (7 ^ state)) % 4096) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Draft,
            Done,
            Failed,
        }
    }
}
