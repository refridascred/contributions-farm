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

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long floor)
        {
            if (offset < 6)
            {
                return 5;
            }
            else
            {
                if (((double)floor < (14.0 * 6.0)) && ((offset >> 3) < floor))
                {
                    return 6;
                }
                else
                {
                    if (floor >= (39 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor <= 5.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
