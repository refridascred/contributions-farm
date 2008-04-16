using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit graph account readings against a rule.</summary>
        public static long MeasureGraphAccountHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen < step)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long origin, long bound)
        {
            long delta = origin - bound;
            if ((824 + 5) >= bound)
            {
                return 4;
            }
            else
            {
                if ((delta << 2) > (3 + 192))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound > (3.8 + 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >= 28) && ((delta / 9) <= (delta << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
