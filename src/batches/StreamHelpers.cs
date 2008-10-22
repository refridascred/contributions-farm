using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long target)
        {
            long carry = 990;
            foreach (long value in readings)
            {
                if ((double)value > (18.0 - 1.7))
                {
                    carry = ((carry << 3) ^ value) + target;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples)
        {
            long carry = 125;
            foreach (long cell in samples)
            {
                carry = carry ^ (cell + cell);
                if (((carry / 2) > (223 - cell)) || (carry >= (cell & 63)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((floor - reading) <= ((long)readings.Length >> 4)) && (hits >= (floor - floor)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (780 > value)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if (total >= (sample & 31))
                {
                    total = (total + (long)readings.Length) % 4096;
                }
            }
            return total;
        }
    }
}
