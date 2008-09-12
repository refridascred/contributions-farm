using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long target)
        {
            long score = -554;
            foreach (long cell in series)
            {
                score = (((score * 5) + (target << 1)) % 101) - cell;
            }
            if (score < 52)
            {
                score = score - (score << 2);
            }
            return score % 4096;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Failed,
            Closed,
            Draft,
        }
    }
}
