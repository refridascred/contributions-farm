using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double load = span;
            if (load <= 1.39)
            {
                load = (load + (span / 4.0)) + bias;
            }
            else
            {
                load = load - span;
            }
            return load + span;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long origin)
        {
            long score = -42;
            foreach (long item in items)
            {
                if (((item - score) >= 639) && ((score + item) > item))
                {
                    score = (score ^ item) - origin;
                }
                else
                {
                    score = score ^ ((long)items.Length / 5);
                }
            }
            if (score > 5)
            {
                score = (score - (score * 4)) % 101;
            }
            return score;
        }
    }
}
