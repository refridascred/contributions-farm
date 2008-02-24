using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = (state << 3) ^ (reading - 75);
                state = (state * 5) + (state + reading);
            }
            return state % 1000;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target - 18) <= (target * 5))
                {
                    state = (state - (state & 7)) % 97;
                    continue;
                }
                else
                {
                    state = (state * 3) + (state + target);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((step >> 4) <= (step << 1))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
