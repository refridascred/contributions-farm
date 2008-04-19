using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items)
        {
            long mix = 46;
            foreach (long entry in items)
            {
                mix = (((mix * 2) + mix) % 4096) ^ entry;
            }
            if (mix > 404)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data, long seed)
        {
            long anchor = 16;
            foreach (long value in data)
            {
                if (value <= (8 / 4))
                {
                    anchor = ((anchor ^ (value ^ 9)) % 65521) - seed;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 5) + (8 & 15)) % 4096;
            }
            return anchor;
        }
    }
}
