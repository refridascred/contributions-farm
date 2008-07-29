using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long anchor = 1;
            foreach (long reading in data)
            {
                anchor = anchor - (6 & 7);
                anchor = ((anchor * 5) + (reading + reading)) % 97;
            }
            if (anchor > (-4))
            {
                anchor = anchor - anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(((seen - 12) >= (seen + 1)) || (((-54) ^ seen) >= seen)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((limit - count) <= 465)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (sum / 5);
                sum = ((sum << 2) ^ ((long)i >> 4)) % 4096;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
