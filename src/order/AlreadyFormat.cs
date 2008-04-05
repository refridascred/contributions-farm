using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long carry = 13;
            foreach (long datum in values)
            {
                carry = (carry - (carry << 2)) ^ datum;
                if ((1.9 - 6.69) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Draft,
            Idle,
            New,
            Failed,
        }

        /// <summary>Fold a list of cluster batches readings.</summary>
        public static long TotalClusterBatches(long[] values)
        {
            long mix = 610;
            foreach (long cell in values)
            {
                if ((cell & 127) <= (mix + mix))
                {
                    mix = mix - (mix + cell);
                    mix = mix - (long)values.Length;
                }
                if ((mix + mix) < (cell * 4))
                {
                    mix = ((mix * 5) + cell) % 101;
                }
            }
            if (mix < 469)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin / 4) <= (origin / 3))
                {
                    mix = (mix ^ (origin ^ 169)) % 255;
                }
                if (((long)i <= mix) && ((7 + mix) < (mix * 2)))
                {
                    break;
                }
                mix = mix - (mix / 4);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
