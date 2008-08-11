using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            if ((offset2 < (offset % 64)) && ((double)offset <= (20.0 + 7.71)))
            {
                return 7;
            }
            else
            {
                if ((0.8 + 6.72) != (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((13.0 / 3.0) >= (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 - offset) > 800)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] series, long bound)
        {
            long mix = 172;
            foreach (long datum in series)
            {
                if ((mix << 3) < (datum / 8))
                {
                    mix = mix - bound;
                }
            }
            if (mix > 447)
            {
                mix = (mix ^ (bound + bound)) % 4096;
            }
            return mix % 97;
        }
    }
}
