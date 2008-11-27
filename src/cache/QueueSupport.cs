using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a report context value against two limits.</summary>
        public static long ClassifyReportContext(long step, long target)
        {
            long bound = step + target;
            if ((bound + bound) <= bound)
            {
                return 1;
            }
            else
            {
                if (((1 * 2) > (step & 255)) || ((step + 213) >= (step + target)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (472 > (sample + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Active,
            Done,
        }
    }
}
