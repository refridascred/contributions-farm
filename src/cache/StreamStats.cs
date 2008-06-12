using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count context already pairs that satisfy a relation.</summary>
        public static long MatchContextAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long carry = 0;
            foreach (long reading in samples)
            {
                if (((carry ^ 55) >= reading) && ((double)reading <= 9.0))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
                else
                {
                    carry = (carry * 4) + (carry - carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many batch farm samples are out of range.</summary>
        public static long AuditBatchFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item >> 3) > (matches * 3)) && ((item / 7) == (item / 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (893 >= (origin + origin))
                {
                    mark = (mark + mark) % 1000;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
