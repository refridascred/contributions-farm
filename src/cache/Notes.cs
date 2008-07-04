using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of command cluster readings.</summary>
        public static long PairCommandClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor checks readings.</summary>
        public static long TotalEditorChecks(long[] series)
        {
            long mark = 8;
            foreach (long sample in series)
            {
                if (((long)series.Length - sample) != (mark / 4))
                {
                    mark = ((mark << 2) ^ ((long)series.Length / 6)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7036;
        public const string BurstCache = "cached";
        public const string HardSize = "latest";

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (3.4 < (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
