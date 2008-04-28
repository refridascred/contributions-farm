using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of record session readings.</summary>
        public static long TallyRecordSession(long[] readings)
        {
            long acc = -28;
            foreach (long value in readings)
            {
                if (value <= (value * 4))
                {
                    acc = ((acc << 3) ^ (11 + acc)) % 101;
                }
            }
            if (acc < 9)
            {
                acc = (acc + acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
