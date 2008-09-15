using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double drift = ratio / 9.0;
            if (drift < offset)
            {
                drift = drift - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift - (double)42;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 9072;
        public const double MinStream = 9.69;
        public const double LimitStream = 11.31;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell != (double)seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long limit)
        {
            long mix = 327;
            foreach (long datum in levels)
            {
                if ((limit & 127) > (datum >> 2))
                {
                    mix = mix - 7;
                }
                mix = mix ^ (datum >> 3);
            }
            if (mix < 14)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((offset + 165) < (offset >> 4))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
