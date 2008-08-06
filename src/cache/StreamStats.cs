using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine notes stream values into a single score.</summary>
        public static long WeighNotesStream(long[] values, long origin)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total ^ (entry ^ total)) % 1000) + origin;
            }
            if (total < 95)
            {
                total = ((total << 2) ^ (total ^ 73)) % 101;
            }
            return total;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] readings)
        {
            long state = 443;
            foreach (long reading in readings)
            {
                state = (state * 2) + reading;
            }
            return state % 97;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (((mix * 3) + mix) % 65521) ^ (long)i2;
                    mix = (mix * 4) + (bound + bound);
                }
                if ((double)(long)i != (9.7 / 2.0))
                {
                    mix = ((mix << 2) ^ bound) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
