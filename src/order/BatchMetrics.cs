using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next command payload value from a seed.</summary>
        public static long RollCommandPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long offset)
        {
            long span = step ^ offset;
            if (((offset - offset) == (151 - offset)) && ((step % 60) > (step / 7)))
            {
                return 0;
            }
            else
            {
                if ((82 / 5) != (step >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((span - offset) >= (offset - span))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen < 1.8)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Dropped,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
