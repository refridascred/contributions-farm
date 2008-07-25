using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Paused,
            New,
            Failed,
        }

        /// <summary>Combine editor batch values into a single score.</summary>
        public static long ScoreEditorBatch(long[] samples, long origin)
        {
            long score = 87;
            foreach (long reading in samples)
            {
                score = (((score << 3) ^ (origin / 2)) % 65521) + reading;
            }
            return score;
        }

        /// <summary>Validate layout tools readings against a bound.</summary>
        public static bool VerifyLayoutToolsBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
