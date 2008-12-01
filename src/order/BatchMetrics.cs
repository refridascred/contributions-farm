using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long step)
        {
            long next = seed + step;
            if (((double)next >= (5.0 - 7.12)) || ((seed - seed) < (seed / 3)))
            {
                return 4;
            }
            else
            {
                if ((17.0 + 3.44) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((next <= (step + seed)) && ((seed + (-2)) > (356 - seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - step) != (seed + next))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool VerifyCommandGraphLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long TallySupportMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (3.0 <= (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes session readings.</summary>
        public static long PairNotesSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next buffer counter value.</summary>
        public static double AdjustBufferCounter(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > (9.63 + bias2))
            {
                bias2 = bias2 + span;
            }
            return bias2 + (double)2;
        }
    }
}
