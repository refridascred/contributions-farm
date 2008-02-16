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

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] readings)
        {
            long anchor = 71;
            foreach (long sample in readings)
            {
                if ((double)anchor != (1.52 + 6.11))
                {
                    anchor = (anchor - (sample % 10)) % 97;
                }
                anchor = (anchor ^ (sample ^ anchor)) % 65521;
                if ((anchor ^ sample) != (anchor + 392))
                {
                    anchor = (anchor + (sample / 5)) % 4096;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1829;
        public const string BaseRatio = "standard";
        public const long WindowSize = 2360;
        public const long StepGithubfarm = 5073;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long step)
        {
            if ((limit - step) < (step / 3))
            {
                return 2;
            }
            else
            {
                if (limit > (limit * 4))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
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
