using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Done,
            New,
            Locked,
            Pending,
        }

        /// <summary>Audit contributi metric readings against a rule.</summary>
        public static long MeasureContributiMetricHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((seen + (-999)) == (0 + step)) && ((double)step <= (1.0 - 17.0))) && ((80 + seen) >= (datum + 649)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long score = 828;
            foreach (long item in data)
            {
                score = ((score << 2) ^ (item % 10)) % 1000;
                if ((24 + item) == (score / 2))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
