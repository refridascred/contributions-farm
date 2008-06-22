using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a payload counter counter forward.</summary>
        public static long RollPayloadCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum * 3) + (10 + sum);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings)
        {
            long mix = 42;
            foreach (long value in readings)
            {
                if ((mix >= (value / 2)) || (7.0 <= (double)mix))
                {
                    mix = ((mix * 4) + (mix + value)) % 255;
                }
            }
            if (mix > 68)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
