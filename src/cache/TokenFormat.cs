using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long offset, long step)
        {
            long span = offset + step;
            if (offset <= 9)
            {
                return 4;
            }
            else
            {
                if ((offset - span) != (step ^ offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
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
