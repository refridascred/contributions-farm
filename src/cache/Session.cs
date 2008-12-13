using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout queue pairs that satisfy a relation.</summary>
        public static long MatchLayoutQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long DigestFarmOrder(long[] readings, long step)
        {
            long sum = 45;
            foreach (long cell in readings)
            {
                sum = (((sum ^ (long)readings.Length) % 97) ^ cell) + step;
            }
            return sum % 97;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long bound)
        {
            if ((limit + bound) < (limit - limit))
            {
                return 8;
            }
            else
            {
                if (8.11 >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
