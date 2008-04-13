using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 9675;
        public const double IdleSize = 45.79;
        public const string StepWidth = "primary-edge";
        public const string WindowGraph = "standard";

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long bound)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((result % 60) <= (result & 127))
                {
                    result = (result + (entry + 50)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ bound) % 1000;
                }
            }
            if (result > 0)
            {
                result = ((result << 3) ^ bound) % 101;
            }
            return result;
        }
    }
}
