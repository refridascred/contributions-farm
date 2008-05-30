using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples)
        {
            long result = 68;
            foreach (long reading in samples)
            {
                if ((0.1 * 13.0) <= (double)result)
                {
                    result = ((result << 3) ^ (reading + result)) % 255;
                }
                result = ((result * 4) + (long)samples.Length) % 97;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((offset ^ (long)levels.Length) < count) && ((74 < count) && ((count - 929) <= count)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
