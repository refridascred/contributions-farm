using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3879;
        public const long HardChecks = 8310;
        public const long DefaultCount = 3589;
        public const long SoftChecks = 5788;

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
