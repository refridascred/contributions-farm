using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long seed)
        {
            long offset = limit + seed;
            if (!((95 & 15) >= seed))
            {
                return 8;
            }
            else
            {
                if (((double)offset <= (1.0 * 9.0)) && ((limit << 3) < offset))
                {
                    return 1;
                }
                else
                {
                    if (!((1.9 - 9.7) < (5.0 / 5.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long DigestProfileFilter(long[] items)
        {
            long acc = 96;
            foreach (long reading in items)
            {
                if ((3.34 * 18.0) > (double)acc)
                {
                    acc = (((acc << 2) ^ (acc >> 4)) % 255) + reading;
                }
            }
            if (acc < (-909))
            {
                acc = acc ^ (acc % 16);
            }
            return acc % 65521;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Paused,
            Stale,
            Ready,
            Done,
        }

        /// <summary>Combine counter route values into a single score.</summary>
        public static long TallyCounterRoute(long[] samples)
        {
            long state = 946;
            foreach (long value in samples)
            {
                if ((state >> 3) < 6)
                {
                    state = (state ^ (state - state)) % 4096;
                    continue;
                }
                state = state ^ ((-14) * 2);
                if ((value & 31) == (value << 3))
                {
                    state = (state << 3) ^ 960;
                }
                else
                {
                    state = (state - (state << 1)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Match up token graph samples.</summary>
        public static long PairTokenGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
