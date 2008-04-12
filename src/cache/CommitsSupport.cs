using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a batches contributi counter forward.</summary>
        public static long RollBatchesContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - ((long)i + step)) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long bound)
        {
            if (!((offset / 8) < (offset >> 3)))
            {
                return 0;
            }
            else
            {
                if ((offset * 3) < offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset - 524) > (bound << 2)) && ((double)bound == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((step & 127) <= (step >> 1)) && ((373 + entry) > (822 << 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
