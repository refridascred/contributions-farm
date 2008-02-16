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

        /// <summary>Roll a notes report counter forward.</summary>
        public static long SeriesNotesReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
