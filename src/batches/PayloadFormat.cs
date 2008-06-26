using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((4 << 3) < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate farm report readings against a bound.</summary>
        public static bool CheckFarmReportRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
