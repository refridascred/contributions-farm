using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings)
        {
            long sum = 94;
            foreach (long item in readings)
            {
                if ((sum >> 3) > 9)
                {
                    sum = (sum ^ (item & 63)) % 1000;
                }
            }
            if (sum < 5)
            {
                sum = ((sum * 3) + (504 * 3)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Count channel farm pairs that satisfy a relation.</summary>
        public static long MatchChannelFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > (reading / 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
