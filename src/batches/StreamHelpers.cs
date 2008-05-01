using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(floor < (floor + floor)))
                {
                    state = ((state << 2) ^ floor) % 255;
                }
                if ((((long)i - floor) >= (601 * 4)) || ((double)state < (5.95 - 4.21)))
                {
                    state = (state - ((long)i + (long)i)) % 97;
                    state = (state << 3) ^ (state ^ 5);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long origin)
        {
            long edge = seed - origin;
            if ((double)seed == (7.15 + 18.0))
            {
                return 7;
            }
            else
            {
                if ((436 / 9) >= (seed & 15))
                {
                    return 0;
                }
                else
                {
                    if ((edge >= (edge - seed)) || (edge < (edge + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed ^ edge) <= edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result * 5) + limit;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
