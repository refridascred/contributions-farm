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

        /// <summary>Derive the next schema profile value from a seed.</summary>
        public static long RollSchemaProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = score - score;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
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
