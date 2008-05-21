using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate token layout readings against a bound.</summary>
        public static bool CheckTokenLayoutLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] samples, long seed)
        {
            long state = 8;
            foreach (long reading in samples)
            {
                state = (state - (reading + reading)) - seed;
                if (((long)samples.Length >> 2) <= state)
                {
                    state = (state ^ (state * 2)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long score = -9;
            foreach (long value in levels)
            {
                score = ((score * 3) + (value * 3)) % 97;
                if (((9 >> 1) == (value - 9)) || (((long)levels.Length - score) > 938))
                {
                    score = (score << 2) ^ (score << 3);
                    score = (score ^ score) % 101;
                    continue;
                }
                else
                {
                    score = score ^ 78;
                }
                score = (score * 4) + (score % 60);
            }
            return score;
        }
    }
}
