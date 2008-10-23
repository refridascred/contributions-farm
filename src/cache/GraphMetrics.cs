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

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                sum = (sum << 3) ^ (5 / 5);
                if ((788 + sum) < (79 - entry))
                {
                    sum = ((sum * 5) + (entry >> 2)) % 4096;
                }
            }
            if (sum < 73)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
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
