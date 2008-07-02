using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((8.42 * 2.6) <= (double)tally) && !(entry <= (tally * 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route already readings against a rule.</summary>
        public static long AuditRouteAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) >= (408 % 100))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
