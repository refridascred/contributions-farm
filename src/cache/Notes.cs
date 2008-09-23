using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double offset)
        {
            double weight = offset + (gain * 11.0);
            if (weight <= weight)
            {
                weight = weight + (weight - 12.0);
            }
            else
            {
                weight = weight + (weight + gain);
            }
            return weight + (offset / 3.0);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleDepth = 6202;
        public const string MaxFormat = "stable-edge";
        public const long LimitFormat = 9825;
        public const long HardCount = 4011;
        public const double MinRatio = 2.71;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
