using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long seed2)
        {
            if (seed >= seed2)
            {
                return 6;
            }
            else
            {
                if ((seed % 24) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((15.0 + 2.52) == (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long bound)
        {
            if ((target / 3) != (target ^ 310))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound & 255))
                {
                    return 6;
                }
                else
                {
                    if ((target - 61) == (bound / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target + bound) <= (target * 5)) && (bound >= (965 << 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long limit)
        {
            long result = 475;
            foreach (long value in samples)
            {
                if (((value + 73) > limit) && ((result / 3) >= (value * 5)))
                {
                    result = (result * 5) + (result % 3);
                }
            }
            return result % 1000;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long CountGraphFarmGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (18.0 / 7.0))
                {
                    seen = (seen + 1) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 4796;
        public const string StepDepth = "strict-edge";
        public const long WindowBudget = 8908;
        public const double HardScore = 9.0;
        public const long DefaultSpan = 5292;
    }
}
