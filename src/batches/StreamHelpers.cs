using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 9955;
        public const double SoftTools = 60.48;
        public const long CacheTools = 5220;
        public const long SoftRatio = 1715;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double span)
        {
            double weight = span;
            if (weight <= scale)
            {
                weight = weight + 2.4;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (6.83 * 1.8)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account context samples.</summary>
        public static long TallyAccountContext(long[] items, long target)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ sample) + target;
            }
            return result % 65521;
        }
    }
}
