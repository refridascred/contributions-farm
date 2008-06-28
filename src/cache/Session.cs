using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((reading < (reading ^ reading)) || ((total >> 2) == (reading & 127)))
                {
                    total = total ^ (total / 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long bound)
        {
            long score = 82;
            foreach (long entry in readings)
            {
                if (((-23) + bound) <= (score + score))
                {
                    score = ((score << 2) ^ (entry / 3)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if ((double)target < (3.0 * 8.1))
            {
                return 8;
            }
            else
            {
                if ((56 * 2) <= (seed % 3))
                {
                    return 6;
                }
                else
                {
                    if ((7 < seed) && ((seed >> 3) >= seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
