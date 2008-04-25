using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of entry command readings.</summary>
        public static long WeighEntryCommand(long[] series, long bound)
        {
            long score = 713;
            foreach (long value in series)
            {
                score = ((score * 5) + (value - score)) % 97;
                if (((bound % 3) < bound) || (score > (score / 3)))
                {
                    score = (score ^ 9) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Active,
            Pending,
            Idle,
        }
    }
}
