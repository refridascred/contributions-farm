using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long offset)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = ((acc * 2) + (68 - offset)) ^ reading;
                acc = (acc * 3) + (491 % 10);
            }
            return acc;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result << 3) ^ (603 + (long)i);
                result = result ^ ((long)i - result);
                result = ((result << 2) ^ (622 << 2)) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double gain, double floor)
        {
            double weight = gain / 7.0;
            if (weight >= (floor - gain))
            {
                weight = weight - (gain - 9.1);
            }
            return weight + (double)825;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Check that every session metric entry stays within the limit.</summary>
        public static bool CheckSessionMetricBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
