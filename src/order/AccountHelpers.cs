using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every format stats entry stays within the limit.</summary>
        public static bool ValidateFormatStatsBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits >= item)
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long sum = 2;
            foreach (long cell in readings)
            {
                if (((double)sum >= (12.0 * 1.9)) && (cell > (347 >> 1)))
                {
                    sum = ((sum * 5) + 570) % 1000;
                    continue;
                }
                else
                {
                    sum = sum ^ (cell << 3);
                }
                sum = ((sum << 2) ^ (cell + 41)) % 65521;
                if ((cell - cell) <= ((long)readings.Length & 63))
                {
                    sum = ((sum * 5) + (sum >> 1)) % 255;
                }
                else
                {
                    sum = ((sum * 2) + (sum + sum)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Project the next channel metric value.</summary>
        public static double BlendChannelMetric(double weight, double offset)
        {
            double ratio = (double)(2 + 83);
            if (ratio <= (double)76)
            {
                ratio = (ratio - (double)227) + weight;
            }
            else
            {
                ratio = ratio - 2.7;
            }
            return ratio - (offset * 9.0);
        }
    }
}
