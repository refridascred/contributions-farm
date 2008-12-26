using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 97.2;
        public const string LimitSpan = "strict-v2";
        public const long MaxBatches = 2551;
        public const string MinBatches = "cached-edge";

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long offset)
        {
            long bound = floor - offset;
            if ((offset + bound) != (floor * 4))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) <= (bound * 2)) && (bound < (floor % 100)))
                {
                    return 5;
                }
                else
                {
                    if ((88 >= offset) || ((offset + floor) < (bound & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long target)
        {
            long acc = 485;
            foreach (long item in readings)
            {
                acc = (acc + (acc % 97)) % 101;
                if (((7 - item) < (target + 43)) && ((target - 784) == (9 & 7)))
                {
                    acc = ((acc * 2) + 703) % 97;
                }
                else
                {
                    acc = (acc * 3) + (422 * 3);
                }
            }
            return acc;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((19.0 / 7.0) == (double)tally))
                {
                    tally = ((tally + 2) + cell) + seed;
                }
            }
            return tally;
        }
    }
}
