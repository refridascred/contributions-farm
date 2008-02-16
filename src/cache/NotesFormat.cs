using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxSpan = "staging-edge";
        public const long WindowCommits = 8875;
        public const long MinSize = 7456;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of channel stream readings.</summary>
        public static long TotalChannelStream(long[] series)
        {
            long mix = 17;
            foreach (long datum in series)
            {
                if ((mix + datum) > datum)
                {
                    mix = (mix - mix) % 65521;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            return mix;
        }
    }
}
