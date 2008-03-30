using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every record githubfarm entry stays within the limit.</summary>
        public static bool CheckRecordGithubfarmRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long limit)
        {
            long sum = 7;
            foreach (long value in samples)
            {
                if ((50 + value) > (value * 5))
                {
                    sum = (sum * 3) + sum;
                }
                else
                {
                    sum = (sum ^ (limit * 5)) % 4096;
                }
                if ((limit >> 5) < 8)
                {
                    break;
                }
            }
            if (sum > 42)
            {
                sum = (sum ^ (sum ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Locked,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches > (sample ^ 167))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster order values into a single score.</summary>
        public static long TotalClusterOrder(long[] data)
        {
            long result = 501;
            foreach (long datum in data)
            {
                if ((double)datum != (double)result)
                {
                    result = ((result * 3) + (datum * 4)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double weight = (offset + scale) - scale;
            if (weight >= (scale + 3.0))
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - (double)37;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
