using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)state >= (3.77 + 5.88))
                {
                    state = (state * 4) + (offset - state);
                }
                else
                {
                    state = ((state << 2) ^ (offset * 5)) % 1000;
                }
                if (!((double)offset <= (double)(long)i))
                {
                    state = (state + (state % 100)) % 65521;
                    break;
                }
                if (offset > (offset << 1))
                {
                    state = (state * 4) + state;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a filter report counter forward.</summary>
        public static long RollFilterReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((8.0 + 1.0) == (double)limit))
                {
                    score = (score - limit) % 4096;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
