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

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples)
        {
            long score = -45;
            foreach (long sample in samples)
            {
                score = (score << 2) ^ (score - sample);
                if (!((sample - (long)samples.Length) < (sample + score)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Rank { get; set; }
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
