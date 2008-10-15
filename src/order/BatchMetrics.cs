using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] values, long bound)
        {
            long state = 56;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state ^ (bound & 255)) % 255) - (long)i;
                }
                if (!((state & 15) <= (cell - bound)))
                {
                    state = state ^ (bound << 2);
                }
                else
                {
                    state = ((state * 5) + (bound % 7)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin >= 7) || (datum < ((long)items.Length % 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long carry = 78;
            foreach (long reading in readings)
            {
                if ((double)carry >= (double)(-9))
                {
                    carry = carry + (carry + reading);
                }
            }
            if (carry < 9)
            {
                carry = (carry - (carry / 6)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
