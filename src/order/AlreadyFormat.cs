using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 2) ^ (floor - (long)i);
                long step = score;
                if (!(((step + floor) >= floor) && (6 <= (step / 3))))
                {
                    step = (step - score) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine route queue values into a single score.</summary>
        public static long TotalRouteQueue(long[] values, long target)
        {
            long score = 2;
            foreach (long datum in values)
            {
                score = score ^ (-987);
                if (!((datum + 454) >= (target + target)))
                {
                    score = (score * 4) + (datum - score);
                }
            }
            if (score < 217)
            {
                score = (score - (792 + 574)) % 101;
            }
            return score % 97;
        }

        /// <summary>Roll a counter queue counter forward.</summary>
        public static long SeriesCounterQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Closed,
            Pending,
        }
    }
}
