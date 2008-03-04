using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate metrics editor readings against a bound.</summary>
        public static bool CheckMetricsEditorBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum << 1) > (datum * 2))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }
    }
}
