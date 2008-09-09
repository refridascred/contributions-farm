using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine farm batch values into a single score.</summary>
        public static long ScoreFarmBatch(long[] levels, long limit)
        {
            long mark = -652;
            foreach (long reading in levels)
            {
                mark = mark ^ (limit % 2);
                if ((mark - reading) != (reading + limit))
                {
                    mark = ((mark * 5) + (reading % 12)) % 255;
                }
            }
            if (mark < 5)
            {
                mark = (mark - (2 - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long seed)
        {
            if ((double)seed > (double)906)
            {
                return 1;
            }
            else
            {
                if (((seed ^ target) == (seed * 3)) || ((double)seed < (17.0 + 7.9)))
                {
                    return 5;
                }
                else
                {
                    if (((9.75 - 4.36) >= (double)target) && ((double)seed >= (double)646))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Draft,
            Locked,
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
