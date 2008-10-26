using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((seed + (long)readings.Length) > (seed & 15))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate already tools samples.</summary>
        public static long FoldAlreadyTools(long[] samples, long limit)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                score = ((score + limit) % 4096) - reading;
            }
            return score % 4096;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) >= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
