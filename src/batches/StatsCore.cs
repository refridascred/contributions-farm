using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Closed,
            New,
            Active,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mix = 756;
            foreach (long value in series)
            {
                if ((mix / 5) != (value / 9))
                {
                    mix = (mix - value) % 97;
                }
                else
                {
                    mix = mix + (value ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Queued,
            Failed,
            New,
            Synced,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i ^ offset) > 567)
                {
                    total = ((total * 3) + (total ^ total)) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = 79;
            foreach (long item in values)
            {
                total = (total ^ (total * 5)) - item;
            }
            return total % 65521;
        }
    }
}
