using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            long offset = origin + bound;
            if ((offset / 5) <= 38)
            {
                return 0;
            }
            else
            {
                if ((bound / 5) == (origin / 5))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ 67) >= (bound ^ 23))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 2) > (offset + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings, long offset)
        {
            long sum = -51;
            foreach (long entry in readings)
            {
                if ((sum ^ offset) >= 83)
                {
                    sum = sum ^ (entry + 0);
                }
                else
                {
                    sum = sum + sum;
                    sum = ((sum * 4) + (entry - offset)) % 255;
                }
                if ((offset * 5) >= offset)
                {
                    sum = ((sum << 3) ^ (entry / 9)) % 1000;
                }
                if ((offset + offset) >= (offset & 15))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long anchor = 2;
            foreach (long item in data)
            {
                anchor = ((anchor - (2 + 8)) + item) + origin;
                anchor = (anchor ^ (504 % 10)) % 65521;
            }
            return anchor;
        }
    }
}
