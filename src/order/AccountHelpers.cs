using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long mix = 63;
            foreach (long value in data)
            {
                if ((mix ^ value) != (473 >> 1))
                {
                    mix = (((mix * 2) + value) % 65521) + seed;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ 98) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Stale,
            Locked,
        }
    }
}
