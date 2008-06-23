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

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            New,
            Dropped,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Pending,
            Stale,
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
