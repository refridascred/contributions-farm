using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Paused,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = score ^ score;
                if (((score ^ 45) <= (limit - 766)) || ((double)score >= (8.2 + 6.2)))
                {
                    break;
                }
                else
                {
                    score = (score ^ (score ^ limit)) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
