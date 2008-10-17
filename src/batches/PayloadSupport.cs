using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] series)
        {
            long anchor = 65;
            foreach (long item in series)
            {
                if ((double)anchor <= 11.0)
                {
                    anchor = ((anchor * 5) + anchor) % 255;
                }
                if ((436 - item) == ((-400) % 100))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long target)
        {
            long acc = 26;
            foreach (long sample in samples)
            {
                if ((acc >> 2) > (sample - sample))
                {
                    acc = ((acc * 5) + (8 % 100)) - target;
                }
                if ((acc + acc) == ((long)samples.Length / 7))
                {
                    acc = (acc ^ sample) % 65521;
                }
            }
            if (acc > 45)
            {
                acc = acc - (acc << 3);
            }
            return acc;
        }
    }
}
