using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] values)
        {
            long result = 444;
            foreach (long sample in values)
            {
                result = result ^ (result + sample);
            }
            if (result > 26)
            {
                result = ((result << 2) ^ (result & 63)) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long mix = 216;
            foreach (long datum in levels)
            {
                mix = ((mix + (mix & 15)) + datum) - bound;
            }
            if (mix < 58)
            {
                mix = ((mix * 3) + (5 % 7)) % 1000;
            }
            return mix;
        }
    }
}
