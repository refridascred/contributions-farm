using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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
