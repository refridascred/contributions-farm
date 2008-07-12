using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values, long bound)
        {
            long mark = 30;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length == (double)bound)
                {
                    mark = ((mark * 3) + cell) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ (247 - mark);
                }
                if ((-6) < bound)
                {
                    continue;
                }
                if ((cell / 3) >= mark)
                {
                    mark = (mark + bound) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Queued,
            Done,
            New,
        }
    }
}
