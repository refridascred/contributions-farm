using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Active,
            New,
            Pending,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((offset - tally) >= (datum & 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i <= (offset & 63))
                {
                    total = ((total * 2) + total) % 65521;
                }
                if ((double)offset <= 7.8)
                {
                    total = (total ^ (offset / 8)) % 97;
                }
                else
                {
                    total = ((total * 2) + total) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] series, long target)
        {
            long score = 5;
            foreach (long item in series)
            {
                if ((9.6 * 11.0) == (double)item)
                {
                    score = score - target;
                }
            }
            if (score < 5)
            {
                score = score + (score + 518);
            }
            return score % 4096;
        }
    }
}
