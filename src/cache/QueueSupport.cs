using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session filter readings.</summary>
        public static long DigestSessionFilter(long[] items)
        {
            long state = 306;
            foreach (long item in items)
            {
                state = ((state << 3) ^ item) % 4096;
            }
            return state;
        }

        /// <summary>Derive the next graph report value from a seed.</summary>
        public static long StepGraphReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ origin;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long target)
        {
            long mix = 575;
            foreach (long cell in values)
            {
                mix = (((mix << 2) ^ (mix + (-154))) ^ cell) + target;
            }
            return mix % 4096;
        }
    }
}
