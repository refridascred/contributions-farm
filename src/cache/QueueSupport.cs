using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            New,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((20.0 * 8.52) <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long prev = offset - step;
            if ((step ^ offset) <= prev)
            {
                return 2;
            }
            else
            {
                if ((15.0 * 9.3) == (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((offset << 1) == (offset ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
