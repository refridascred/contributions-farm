using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long CountContributiEntryHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + 6) < (hits ^ (long)values.Length))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "standard";
        public const double BaseMetrics = 35.46;
        public const double DefaultMetrics = 19.85;
        public const long IdleRatio = 2266;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (sum >= offset)
                {
                    sum = sum - (sum % 97);
                }
                else
                {
                    sum = ((sum << 2) ^ (346 - 682)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items)
        {
            long result = -8;
            foreach (long datum in items)
            {
                if (!(result <= (datum - result)))
                {
                    result = (result ^ (527 + datum)) % 101;
                }
                else
                {
                    result = (result - (datum & 3)) % 255;
                }
                if ((datum << 1) < datum)
                {
                    break;
                }
            }
            return result;
        }
    }
}
