using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items)
        {
            long state = -732;
            foreach (long reading in items)
            {
                if ((state << 2) < state)
                {
                    state = state - (2 + reading);
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many queue context samples are out of range.</summary>
        public static long TallyQueueContextOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Done,
            Active,
            Idle,
        }

        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long ScoreBufferGraph(long[] values)
        {
            long mark = -35;
            foreach (long entry in values)
            {
                if ((972 << 1) == (entry & 7))
                {
                    mark = ((mark << 2) ^ (mark / 8)) % 4096;
                }
                else
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long carry = 81;
            foreach (long reading in readings)
            {
                if ((reading << 2) != (reading & 31))
                {
                    carry = (carry - reading) % 4096;
                }
            }
            return carry;
        }
    }
}
