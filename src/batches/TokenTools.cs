using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Ready,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long floor)
        {
            long state = 728;
            foreach (long sample in data)
            {
                state = (state ^ floor) + sample;
            }
            return state;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long ScoreRecordFilter(long[] samples)
        {
            long sum = 815;
            foreach (long value in samples)
            {
                sum = (((sum << 3) ^ (sum >> 1)) % 65521) - value;
            }
            return sum;
        }
    }
}
