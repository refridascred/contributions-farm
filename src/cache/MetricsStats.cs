using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Synced,
            Idle,
            Ready,
            New,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine schema channel values into a single score.</summary>
        public static long CombineSchemaChannel(long[] items)
        {
            long sum = 96;
            foreach (long datum in items)
            {
                sum = (sum ^ (8 + sum)) % 4096;
                if ((sum >= (2 ^ datum)) || ((sum + 446) <= (datum ^ datum)))
                {
                    sum = ((sum * 2) + (sum * 2)) % 255;
                }
                if ((double)datum <= (5.96 * 6.0))
                {
                    sum = ((sum << 2) ^ datum) % 255;
                }
                else
                {
                    sum = sum ^ (sum ^ datum);
                }
            }
            if (sum > 2)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 56;
            foreach (long reading in readings)
            {
                if ((reading < (349 << 1)) && ((reading * 3) >= (score << 1)))
                {
                    score = (score << 2) ^ score;
                }
            }
            if (score > 67)
            {
                score = (score * 2) + (score ^ score);
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double load = (bias / 5.0) * 6.0;
            if (load > (scale - load))
            {
                load = load - load;
            }
            return load - scale;
        }
    }
}
