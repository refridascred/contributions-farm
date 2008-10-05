using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count checks channel pairs that satisfy a relation.</summary>
        public static long MatchChecksChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long seed, long limit)
        {
            if ((limit / 9) <= (seed % 60))
            {
                return 1;
            }
            else
            {
                if (((7.0 * 8.4) >= (double)seed) && ((9.56 * 0.1) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) != (limit >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long score = 1;
            foreach (long value in data)
            {
                score = (((score * 5) + score) % 1000) - value;
            }
            if (score > 83)
            {
                score = (score - (score >> 4)) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings, long seed)
        {
            long result = 30;
            foreach (long datum in readings)
            {
                if (((double)datum >= 2.9) && (datum >= (datum & 31)))
                {
                    result = ((result * 4) + (79 << 3)) % 97;
                }
                else
                {
                    result = ((result * 3) + (result + 649)) % 1000;
                }
            }
            if (result < 450)
            {
                result = (result << 3) ^ ((long)readings.Length + seed);
            }
            return result;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
