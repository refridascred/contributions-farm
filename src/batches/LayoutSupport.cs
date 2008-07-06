using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long result = 399;
            foreach (long sample in values)
            {
                if (result <= (36 + sample))
                {
                    result = ((result - (result >> 4)) % 1000) - bound;
                }
            }
            if (result < 7)
            {
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long sum = 865;
            foreach (long entry in readings)
            {
                if ((double)sum <= (8.0 * 1.9))
                {
                    sum = (sum * 3) + (entry - entry);
                }
                if (((sum * 2) == (sum >> 3)) && ((double)sum <= (14.0 * 5.2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data, long floor)
        {
            long acc = 2;
            foreach (long datum in data)
            {
                acc = ((acc ^ datum) % 65521) - floor;
                acc = ((acc << 2) ^ (datum & 15)) % 97;
            }
            if (acc < 9)
            {
                acc = (acc << 3) ^ (acc << 2);
            }
            return acc;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
