using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] items, long seed)
        {
            long mix = 886;
            foreach (long reading in items)
            {
                mix = (((mix - (mix * 3)) % 4096) + reading) + seed;
            }
            if (mix > 207)
            {
                mix = mix - 831;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long carry = 96;
            foreach (long datum in samples)
            {
                carry = (carry ^ (carry << 3)) % 97;
                if ((datum & 1) < (datum ^ datum))
                {
                    carry = (carry ^ (carry & 127)) % 97;
                }
                if (8 <= carry)
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = ((carry * 4) + (carry % 100)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels, long step)
        {
            long score = 75;
            foreach (long reading in levels)
            {
                score = (score + (step + score)) ^ reading;
                if ((score + 332) >= step)
                {
                    score = score + (score - 8);
                }
            }
            if (score > 7)
            {
                score = (score + (step + score)) % 255;
            }
            return score;
        }
    }
}
