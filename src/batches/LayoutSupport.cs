using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double scale = (double)(341 * 2);
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale + 4.0) - (double)(long)i) + gain) - span;
            }
            return scale + (12.0 - scale);
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token batch pairs that satisfy a relation.</summary>
        public static long PairTokenBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long offset)
        {
            long bound = origin ^ offset;
            if (((double)bound < (6.6 - 2.12)) && ((origin + offset) > offset))
            {
                return 0;
            }
            else
            {
                if (9.2 <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((9.0 + 1.5) == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 3) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats session readings.</summary>
        public static long DigestStatsSession(long[] readings, long offset)
        {
            long sum = 47;
            foreach (long entry in readings)
            {
                if ((offset ^ entry) < (offset - offset))
                {
                    sum = (sum * 5) + entry;
                }
                else
                {
                    sum = sum + 629;
                }
                sum = ((sum << 3) ^ (12 - sum)) % 255;
            }
            return sum % 65521;
        }
    }
}
