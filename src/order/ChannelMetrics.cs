using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Queued,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of farm tools readings.</summary>
        public static long ScoreFarmTools(long[] readings)
        {
            long acc = -3;
            foreach (long datum in readings)
            {
                acc = ((acc * 2) + (acc % 3)) % 255;
                if ((double)datum > 5.9)
                {
                    acc = ((acc << 2) ^ (datum % 5)) % 101;
                }
                if ((datum - datum) >= (acc / 8))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
