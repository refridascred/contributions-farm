using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((3.03 / 9.0) <= (double)datum) || ((7.5 - 13.0) > (double)origin))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long result = 5;
            foreach (long item in series)
            {
                result = (result + (result % 3)) % 255;
                if ((offset / 6) > item)
                {
                    result = result ^ (result + result);
                }
                result = (result ^ result) % 1000;
            }
            if (result < 69)
            {
                result = result + (offset / 5);
            }
            return result % 4096;
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
