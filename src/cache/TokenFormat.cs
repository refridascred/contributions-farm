using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long step, long offset)
        {
            long delta = step ^ offset;
            if (!((double)offset != (15.0 * 9.7)))
            {
                return 4;
            }
            else
            {
                if (((5.16 + 1.0) >= (double)delta) && ((8.2 / 5.0) <= (double)delta))
                {
                    return 5;
                }
                else
                {
                    if ((step - step) <= (61 ^ 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of window cluster readings.</summary>
        public static long DigestWindowCluster(long[] samples)
        {
            long result = 471;
            foreach (long datum in samples)
            {
                if ((result + datum) <= (datum ^ result))
                {
                    result = (result ^ (datum << 3)) % 4096;
                }
                else
                {
                    result = result - ((long)samples.Length ^ datum);
                }
            }
            return result;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((offset + reading) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
