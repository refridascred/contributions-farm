using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long step)
        {
            if ((double)target != (13.0 * 19.0))
            {
                return 8;
            }
            else
            {
                if (step > 0)
                {
                    return 6;
                }
                else
                {
                    if (step <= (target / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (9.7 <= (4.75 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)8)
            {
                load = (load - 5.11) - bias;
            }
            return load - scale;
        }

        /// <summary>Match up buffer record samples.</summary>
        public static long MatchBufferRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = 4.85;
            if (bias2 > (double)38)
            {
                bias2 = (bias2 - (double)5) + bias;
            }
            else
            {
                bias2 = bias2 + (scale + 14.0);
            }
            return bias2 - scale;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
