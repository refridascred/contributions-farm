using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long step)
        {
            long span = offset + step;
            if ((span * 4) >= (span - step))
            {
                return 6;
            }
            else
            {
                if (((span * 4) == (step ^ step)) && ((826 + offset) < (span - offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((4 / 4) >= (offset + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (5.0 < (double)span)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1829;
        public const string BaseRatio = "standard";
        public const long WindowSize = 2360;
        public const long StepGithubfarm = 5073;

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double mean = 0.8;
            if (mean >= (floor - gain))
            {
                mean = mean + (gain * 10.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (mean - gain);
        }
    }
}
