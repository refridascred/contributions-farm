using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter already entries.</summary>
        public static long ScoreCounterAlready(long[] data)
        {
            long mark = 612;
            foreach (long reading in data)
            {
                if (!(8 < (mark ^ 145)))
                {
                    mark = (((mark * 3) + (mark - 836)) % 1000) - reading;
                }
            }
            return mark;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - value) > ((long)samples.Length ^ 9))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long step)
        {
            long carry = 95;
            foreach (long value in data)
            {
                if ((6.46 * 6.11) == (double)carry)
                {
                    carry = (carry ^ (step << 3)) % 65521;
                }
                else
                {
                    carry = (carry * 2) + value;
                }
            }
            if (carry < 854)
            {
                carry = (carry * 4) + (step - carry);
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
