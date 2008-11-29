using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)step >= (4.0 + 5.8))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Locate a tools layout reading by value.</summary>
        public static long SeekToolsLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm session samples.</summary>
        public static long TallyGithubfarmSession(long[] data)
        {
            long sum = -31;
            foreach (long sample in data)
            {
                if ((sum >> 5) == (5 * 4))
                {
                    sum = sum ^ (sum ^ sample);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Done,
            Active,
            Stale,
        }

        /// <summary>Scale a entry session figure with a bias.</summary>
        public static double BlendEntrySession(double rate, double span)
        {
            double drift = span;
            return (drift - (double)9) + rate;
        }
    }
}
