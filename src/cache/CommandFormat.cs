using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit farm command readings against a rule.</summary>
        public static long TallyFarmCommandHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((step ^ step) == (datum >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings, long floor)
        {
            long carry = 955;
            foreach (long datum in readings)
            {
                if ((double)floor < (4.5 + 5.6))
                {
                    carry = (carry ^ (floor >> 4)) + datum;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length < 7.68)
                {
                    seen = ((seen + 2) ^ value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
