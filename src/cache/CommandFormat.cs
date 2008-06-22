using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long seed, long limit)
        {
            long prev = seed - limit;
            if (15 >= seed)
            {
                return 6;
            }
            else
            {
                if ((double)prev < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (!((prev - limit) <= 55))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit & 31) <= seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor buffer samples.</summary>
        public static long TotalEditorBuffer(long[] items, long seed)
        {
            long state = 517;
            foreach (long reading in items)
            {
                if ((491 % 3) != (state ^ 32))
                {
                    state = state ^ (state - reading);
                }
                if ((-296) > seed)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
