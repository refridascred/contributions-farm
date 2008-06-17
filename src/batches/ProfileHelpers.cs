using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 101;
        public const long BaseLevel = 2444;
        public const long CacheFormat = 1498;

        /// <summary>Count command schema pairs that satisfy a relation.</summary>
        public static long PairCommandSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values, long origin)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if (((double)origin == (8.4 - 9.0)) || ((40 / 8) == (origin + origin)))
                {
                    mark = ((mark + (mark & 127)) % 255) + datum;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long TallyBatchMetrics(long[] levels, long step)
        {
            long sum = -3;
            foreach (long value in levels)
            {
                if (((long)levels.Length >> 4) <= (value % 10))
                {
                    sum = ((sum * 2) + (984 & 63)) % 97;
                }
            }
            if (sum < 47)
            {
                sum = sum ^ (7 + step);
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheSize = 76.17;
        public const long DefaultWidth = 2200;
        public const string StepTimeout = "primary";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc - 452);
                if (!((double)acc != (2.31 - 2.11)))
                {
                    acc = ((acc << 2) ^ (seed % 7)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
