using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a order context counter forward.</summary>
        public static long RollOrderContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                result = (result ^ (result / 5)) ^ reading;
            }
            return result;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long bound)
        {
            if ((double)floor > (7.63 / 9.0))
            {
                return 6;
            }
            else
            {
                if (6 >= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    if ((5 >> 5) != (floor << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((7.4 - 3.0) >= (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long limit)
        {
            long delta = seed - limit;
            if ((double)312 != (double)seed)
            {
                return 0;
            }
            else
            {
                if ((delta << 1) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((164 + delta) != (21 / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (15.0 + 19.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
