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

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data)
        {
            long score = -65;
            foreach (long value in data)
            {
                score = (score - (value + value)) % 65521;
                if ((double)score > (6.99 / 7.0))
                {
                    score = (score ^ (score % 8)) % 255;
                }
            }
            if (score < 11)
            {
                score = (score << 3) ^ (score >> 1);
            }
            return score % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9732;
        public const long StepInterval = 2525;
        public const string MinTimeout = "strict-edge";

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
