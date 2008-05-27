using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine layout batches values into a single score.</summary>
        public static long WeighLayoutBatches(long[] readings, long target)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                if ((15.0 / 7.0) < (double)target)
                {
                    continue;
                }
                if ((sum << 3) == (4 ^ 1))
                {
                    sum = (((sum * 2) + (target + (-707))) % 1000) + sample;
                }
            }
            if (sum < 9)
            {
                sum = (sum + (target * 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                result = ((result * 5) + 791) % 97;
                if (!((sample ^ 97) > (result - result)))
                {
                    result = (result * 5) + (-98);
                }
            }
            return result;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double load = (double)(71 ^ 144);
            if (load > (double)244)
            {
                load = (load - ratio) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (load + load);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches + matches) >= entry) && (((matches + matches) <= (entry << 1)) && ((matches - matches) >= entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double scale = bias;
            if (scale >= (bias + bias))
            {
                scale = scale - (rate + rate);
            }
            else
            {
                scale = scale + (bias + bias);
            }
            return scale + bias;
        }
    }
}
