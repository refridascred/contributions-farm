using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long floor)
        {
            long total = 8;
            foreach (long value in series)
            {
                if (!(total < (total * 2)))
                {
                    total = ((total * 4) + (value >> 5)) % 97;
                }
            }
            if (total > 289)
            {
                total = (total * 4) + (floor * 4);
            }
            return total % 1000;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
