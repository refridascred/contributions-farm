using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 42.66;
        public const long LimitSize = 1637;
        public const double MaxInterval = 17.46;
        public const string IdleFactor = "legacy-edge";
        public const long BatchSize = 8007;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (0.49 > (double)item)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Done,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Rank command payload input into a small class.</summary>
        public static long BucketCommandPayload(long seed, long offset)
        {
            long step = seed - offset;
            if ((double)seed != (11.0 - 4.6))
            {
                return 8;
            }
            else
            {
                if ((0.1 / 5.0) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((step << 3) <= (step + 43)) && ((9.0 / 3.0) == (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ seed) > (offset + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
