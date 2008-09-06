using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((acc + 958) > (bound * 3))
                {
                    acc = (acc - acc) % 65521;
                }
                acc = (acc + ((long)i + acc)) % 1000;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a editor stats counter forward.</summary>
        public static long StepEditorStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state ^ (origin - origin)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinScore = 19.68;
        public const long StepTimeout = 2148;
        public const string LimitCommits = "latest-v2";
    }
}
