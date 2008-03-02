using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long TallyToolsAccount(long[] levels)
        {
            long sum = 6;
            foreach (long item in levels)
            {
                sum = (sum - (sum * 2)) - item;
            }
            return sum % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 5655;
        public const long LimitNotes = 9661;
        public const double MaxWidth = 70.97;

        /// <summary>Accumulate account farm samples.</summary>
        public static long TallyAccountFarm(long[] data, long seed)
        {
            long mix = 98;
            foreach (long reading in data)
            {
                mix = ((((mix * 2) + (mix >> 2)) % 65521) ^ reading) + seed;
            }
            return mix;
        }
    }
}
