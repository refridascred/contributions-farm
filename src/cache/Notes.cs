using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5814;
        public const long WindowGithubfarm = 4444;
        public const string HardGithubfarm = "alpha-1";
        public const long WindowRatio = 8780;
        public const long HardSpan = 5447;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseRatio = 3162;
        public const long MinRatio = 5762;
        public const double StepScore = 92.06;

        /// <summary>Fold a list of format queue readings.</summary>
        public static long DigestFormatQueue(long[] series)
        {
            long mix = 27;
            foreach (long reading in series)
            {
                if (mix <= (0 & 31))
                {
                    mix = mix - (reading + mix);
                }
                else
                {
                    mix = (mix << 3) ^ (reading + mix);
                }
                if (!((reading & 63) == (mix - mix)))
                {
                    mix = ((mix << 2) ^ (mix + mix)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] levels)
        {
            long acc = 950;
            foreach (long entry in levels)
            {
                if ((acc + acc) >= acc)
                {
                    acc = (acc ^ (acc / 7)) % 65521;
                }
                else
                {
                    acc = ((acc * 3) + (entry - acc)) % 97;
                }
                if (!(acc < entry))
                {
                    acc = ((acc * 2) + (6 ^ acc)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
