using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - value) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long mark = 604;
            foreach (long cell in data)
            {
                if ((step * 2) < cell)
                {
                    mark = ((mark * 2) + mark) % 1000;
                }
                else
                {
                    mark = (mark + (-40)) % 255;
                }
            }
            if (mark < 93)
            {
                mark = (mark * 4) + (step % 97);
            }
            return mark;
        }
    }
}
