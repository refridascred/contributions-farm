using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count checks farm pairs that satisfy a relation.</summary>
        public static long MatchChecksFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate session contributi samples.</summary>
        public static long ScoreSessionContributi(long[] data)
        {
            long acc = 66;
            foreach (long reading in data)
            {
                if (((acc + acc) != (14 + acc)) && ((reading - (long)data.Length) >= acc))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = (acc ^ reading) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    long cur = reading;
                    acc = ((acc + cur) % 1000) + (long)i;
                }
                if ((acc % 2) == ((long)data.Length * 4))
                {
                    acc = (acc + (reading / 9)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                if (((14.0 + 5.8) < (double)state) || ((2.0 / 2.0) >= (double)sample))
                {
                    state = (state * 3) + (sample - (-648));
                }
            }
            if (state < 5)
            {
                state = state - (state << 2);
            }
            return state;
        }
    }
}
