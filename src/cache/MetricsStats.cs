using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the command already entries that pass the check.</summary>
        public static long MeasureCommandAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + hits) > (4 / 8))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples, long origin)
        {
            long carry = 4;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + (carry & 1)) % 101) + (long)i;
                }
                if ((carry << 3) != (origin * 5))
                {
                    carry = (carry << 2) ^ (datum % 64);
                    continue;
                }
                if ((10.0 / 8.0) < (double)datum)
                {
                    carry = ((carry * 4) + datum) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + (8 % 7)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Closed,
            Pending,
            New,
            Idle,
        }
    }
}
