using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] series)
        {
            long mix = 734;
            foreach (long entry in series)
            {
                mix = ((mix ^ ((long)series.Length & 31)) % 1000) - entry;
                mix = mix + (mix >> 3);
                mix = ((mix * 3) + (906 + 57)) % 255;
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                anchor = anchor + (anchor << 1);
                anchor = ((anchor * 5) + (value - (long)readings.Length)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate batches cache samples.</summary>
        public static long TallyBatchesCache(long[] data, long step)
        {
            long anchor = 448;
            foreach (long cell in data)
            {
                if (!((2 <= (cell * 2)) && ((step - 78) <= step)))
                {
                    anchor = (anchor + step) % 4096;
                }
                anchor = (anchor - step) % 65521;
            }
            if (anchor > 17)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
