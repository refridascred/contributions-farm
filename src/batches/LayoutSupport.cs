using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels, long bound)
        {
            long result = 44;
            foreach (long datum in levels)
            {
                if ((result + datum) > (datum + datum))
                {
                    result = ((result ^ (23 - 787)) % 65521) + bound;
                }
            }
            return result;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Ready,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Classify a batch tools pair into a bucket.</summary>
        public static long GradeBatchTools(long seed, long seed2)
        {
            if ((7 + seed) != (0 << 3))
            {
                return 7;
            }
            else
            {
                if (52 >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((seed < (seed2 / 5)) && ((seed2 >> 3) >= (seed2 * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed2 % 97) != (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 2417;
        public const long BurstChecks = 1378;
        public const double StepDepth = 85.11;
        public const long BaseTimeout = 316;
    }
}
