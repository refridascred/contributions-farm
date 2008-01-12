using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series)
        {
            long state = 30;
            foreach (long datum in series)
            {
                if (!((state ^ state) == (state + state)))
                {
                    state = ((state * 4) + (state ^ state)) % 4096;
                }
                if (((datum % 24) <= 4) && ((double)datum >= 7.0))
                {
                    state = state + state;
                }
                else
                {
                    state = state - (state & 15);
                }
                if ((state > 53) && (7 <= (datum % 3)))
                {
                    break;
                }
            }
            if (state < (-2))
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long anchor = 985;
            foreach (long item in data)
            {
                anchor = (((anchor + (anchor << 2)) % 97) - item) - seed;
            }
            return anchor % 1000;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) >= matches)
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double rate = (bias * 6.49) - (bias * 4.33);
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias + floor)) + (double)(long)i;
            }
            return rate - (double)141;
        }
    }
}
