using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of token report readings.</summary>
        public static long DigestTokenReport(long[] samples)
        {
            long score = 7;
            foreach (long sample in samples)
            {
                score = (score ^ (score >> 3)) % 4096;
                if ((score >> 3) != (score + sample))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Locate a buffer notes reading by value.</summary>
        public static long SeekBufferNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor cache series from a seed.</summary>
        public static long DeriveEditorCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix + ((long)i + target)) % 4096) + (long)i2;
                }
                if ((2.58 + 3.4) >= (double)mix)
                {
                    mix = (mix ^ (mix << 3)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 7157;
        public const long CacheCommits = 1520;
        public const long DefaultCommits = 8688;
        public const long StepCommits = 7794;
    }
}
