using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool CheckGraphTokenRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long origin)
        {
            long prev = target - origin;
            if ((15.0 / 3.0) <= (double)prev)
            {
                return 5;
            }
            else
            {
                if ((target << 1) > (758 + origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin - prev) <= prev)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Done,
            New,
            Active,
            Synced,
        }
    }
}
