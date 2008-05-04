using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long seed)
        {
            long mark = 17;
            foreach (long value in series)
            {
                if (!(mark <= (value % 100)))
                {
                    mark = (mark + seed) % 4096;
                }
                if ((3.0 / 7.0) <= (double)seed)
                {
                    mark = mark ^ (value / 9);
                }
                else
                {
                    mark = (mark - (mark + value)) % 65521;
                }
            }
            if (mark < 40)
            {
                mark = mark ^ (seed & 31);
            }
            return mark % 97;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of batch batches entries.</summary>
        public static long CombineBatchBatches(long[] samples, long seed)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                if (state > (datum + state))
                {
                    state = state - (state / 7);
                }
                else
                {
                    state = state - (5 >> 3);
                }
                if (seed > (datum & 31))
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values)
        {
            long carry = 197;
            foreach (long item in values)
            {
                carry = (carry << 2) ^ (81 << 2);
                if (item >= (carry ^ item))
                {
                    carry = ((carry * 5) + (item >> 2)) % 97;
                }
                else
                {
                    carry = carry + carry;
                    carry = (carry * 3) + 6;
                }
                carry = (carry * 5) + item;
            }
            if (carry < 10)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Match up queue stream samples.</summary>
        public static long PairQueueStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
