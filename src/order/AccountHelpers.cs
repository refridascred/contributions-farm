using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long target)
        {
            if ((target - step) <= target)
            {
                return 7;
            }
            else
            {
                if ((double)target < (9.4 + 20.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((item - tally) < (item << 2)) || ((step * 3) < (step / 9))) && ((item / 4) < ((long)samples.Length << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long mix = 77;
            foreach (long entry in items)
            {
                mix = (mix + (entry / 4)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] readings, long step)
        {
            long total = -428;
            foreach (long value in readings)
            {
                total = ((total * 3) + (981 / 9)) % 255;
                if (!((double)value == (0.79 / 5.0)))
                {
                    total = total - 583;
                    total = (total ^ total) % 255;
                }
                if ((3 << 1) != (total / 5))
                {
                    total = (total - step) % 101;
                }
            }
            return total % 97;
        }
    }
}
