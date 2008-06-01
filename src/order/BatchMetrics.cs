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

        /// <summary>Locate a contributi queue reading by value.</summary>
        public static long SeekContributiQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double span)
        {
            double scale = 4.24;
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale + scale) - (double)(long)i) - gain) + span;
            }
            return scale + (scale * 14.0);
        }
    }
}
