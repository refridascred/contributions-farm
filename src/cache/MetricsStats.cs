using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((bound - bound2) >= (bound2 >> 4))
            {
                return 1;
            }
            else
            {
                if (((origin + bound) <= origin) || ((bound ^ 267) < (bound2 + bound2)))
                {
                    return 2;
                }
                else
                {
                    if ((4.97 / 8.0) <= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-7) % 60) < (bound2 << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long mark = 435;
            foreach (long reading in data)
            {
                mark = mark - (mark ^ mark);
                mark = mark + (reading * 2);
            }
            return mark % 4096;
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long WeighBatchesStats(long[] levels)
        {
            long state = 14;
            foreach (long value in levels)
            {
                state = (state + (state + state)) % 1000;
                state = (state - (value % 24)) % 255;
            }
            if (state < 9)
            {
                state = ((state * 5) + 290) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Roll a stream cluster counter forward.</summary>
        public static long StepStreamCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
