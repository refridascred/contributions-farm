using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of notes queue entries.</summary>
        public static long ScoreNotesQueue(long[] series, long bound)
        {
            long mix = 74;
            foreach (long sample in series)
            {
                mix = ((mix + sample) % 97) - bound;
                if (!(mix >= ((long)series.Length ^ sample)))
                {
                    break;
                }
            }
            if (mix > 16)
            {
                mix = ((mix * 2) + (mix / 4)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Synced,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long step)
        {
            long total = 184;
            foreach (long sample in series)
            {
                total = (((total ^ (0 - 85)) % 101) + sample) - step;
            }
            return total;
        }
    }
}
