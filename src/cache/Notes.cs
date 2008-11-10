using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine support cache values into a single score.</summary>
        public static long WeighSupportCache(long[] levels, long offset)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                if (!((total + entry) > 85))
                {
                    total = total + (offset / 8);
                }
            }
            if (total < 243)
            {
                total = (total * 4) + (total >> 1);
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Retry,
            Stale,
            Active,
            Failed,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi account entry that matches the target.</summary>
        public static long SeekContributiAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
