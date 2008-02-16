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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
