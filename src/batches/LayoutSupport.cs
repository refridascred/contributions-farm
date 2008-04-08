using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double bias2 = 6.0;
            if (bias2 >= bias)
            {
                bias2 = (bias2 - bias) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + (8.7 - bias2);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstCount = 9993;
        public const double BaseRoute = 7.36;
        public const double SoftRoute = 57.49;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] values, long limit)
        {
            long anchor = 23;
            foreach (long cell in values)
            {
                if (!((2.0 - 2.85) > (double)anchor))
                {
                    anchor = (anchor << 2) ^ (limit - cell);
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
