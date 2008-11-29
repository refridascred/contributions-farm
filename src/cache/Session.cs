using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a window farm counter forward.</summary>
        public static long DeriveWindowFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!((3 >> 3) < ((long)i - limit)))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) == (floor >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
