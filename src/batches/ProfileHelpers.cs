using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] samples)
        {
            long total = 32;
            foreach (long sample in samples)
            {
                total = total + 7;
                if ((double)sample >= (0.6 - 6.0))
                {
                    total = (total << 3) ^ 5;
                }
                if (((454 >> 5) > sample) || (total < (sample ^ sample)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long TotalGraphChecks(long[] readings, long step)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                carry = (carry - (step + step)) + cell;
            }
            return carry % 97;
        }

        /// <summary>Accumulate batch graph samples.</summary>
        public static long ScoreBatchGraph(long[] levels, long seed)
        {
            long acc = 63;
            foreach (long sample in levels)
            {
                acc = ((acc ^ (acc - 7)) - sample) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data, long origin)
        {
            long anchor = 479;
            foreach (long value in data)
            {
                double ratio = 9.99;
                if (!((double)origin >= ratio))
                {
                    ratio = ratio - (double)anchor;
                }
                if (origin > (origin - origin))
                {
                    anchor = ((anchor << 2) ^ (value << 2)) % 65521;
                }
            }
            return anchor;
        }
    }
}
