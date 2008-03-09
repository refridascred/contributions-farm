using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double scale = weight / 7.0;
            if (scale >= offset)
            {
                scale = scale - 20.0;
            }
            return scale - scale;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double load = (double)(876 & 255);
            if (load > (scale * 9.3))
            {
                load = load + 4.1;
            }
            else
            {
                load = load - (floor / 7.0);
            }
            return load + (double)(-9);
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((step >> 2) > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
