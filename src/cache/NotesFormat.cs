using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate farm command samples.</summary>
        public static long TallyFarmCommand(long[] levels)
        {
            long mix = 953;
            foreach (long datum in levels)
            {
                mix = (mix * 4) + mix;
                if (datum >= (datum - datum))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 97;
                }
                else
                {
                    mix = mix - (datum / 2);
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of githubfarm channel readings.</summary>
        public static long CompareGithubfarmChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }
    }
}
